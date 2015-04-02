using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RowYourBoat.Tree;
using System.Threading.Tasks;
using System.IO;

namespace RowYourBoat
{
    public partial class RowYourBoat : Form
    {
        List<Char> dangerous;

        Graph g;

        ImageController imageController;

        public RowYourBoat()
        {
            InitializeComponent();
        }

        private void RowYourBoat_Load(object sender, EventArgs e)
        {
            lblInfo.Text = String.Empty;
            imageController = new ImageController(pbWolf, pbSheep, pbCabbage, pbBoatman, pbBoat, pbBackground, gbImages);
            imageController.inflatePictures();

            dangerous = createDangerousSituations();
            g = new Graph();
            createTreeProgrammatically(g);
            Vertex start = g.getVertex(Char.BOATMAN | Char.WOLF | Char.SHEEP | Char.CABBAGE);
            Vertex end = g.getVertex(Char.NONE);
            BFS.solve(start, end);
            printSolution(g.trace(end));
        }

        private void createTreeProgrammatically(Graph g)
        {
            Queue<Char> nodes = new Queue<Char>();
            List<Char> chars = new List<Char>(){Char.CABBAGE, Char.SHEEP, Char.WOLF, Char.BOATMAN};
            List<Char> previousNodes = new List<Char>();

            Char positions = chars.Aggregate(new Char(), (a, c) => a | c);
            nodes.Enqueue(positions);
            previousNodes.Add(positions);
            int i = 0;
            bool isBoatmanAtLeft = true;

            while (nodes.Count > 0)
            {
                Char current = nodes.Dequeue();
                isBoatmanAtLeft = current.HasFlag(Char.BOATMAN);
                
                var available = Enum.GetValues(typeof(Char)).Cast<Enum>();
                foreach (Char actor in available.Where((isBoatmanAtLeft ? current : ~current).HasFlag)) {
                    Char afterTransfer = transfer(actor, current, isBoatmanAtLeft);

                    if (isDangerous(afterTransfer, isBoatmanAtLeft) || isRepeated(afterTransfer, previousNodes)) {

                    } else if (isGoal(afterTransfer)) {
                        g.addEdge(current, afterTransfer, i++.ToString());
                        return;
                    } else {
                        g.addEdge(current, afterTransfer, i++.ToString());
                        previousNodes.Add(afterTransfer);
                        nodes.Enqueue(afterTransfer);
                    }
                }
            }

        }

        private bool isGoal(Char afterTransfer)
        {
            return afterTransfer == Char.NONE;
        }

        private bool isRepeated(Char situation, List<Char> moves)
        {
            return moves.Contains(situation);
        }

        private bool isDangerous(Char current, bool a)
        {
            Char currentRelativeToBoatman = a ? current : ~current;
            return dangerous.Any(situation =>
                currentRelativeToBoatman.HasFlag(situation) &&
                !currentRelativeToBoatman.HasFlag(Char.BOATMAN));
        }

        private Char transfer(Char actor, Char positions, bool isBoatmanAtLeft){
            if (!(actor == Char.BOATMAN)) {
                positions = transfer(Char.BOATMAN, positions, isBoatmanAtLeft);
            }

            if (isBoatmanAtLeft) {
                return positions ^ actor;
            } else {
                return positions | actor;
            }
        }

        private List<Char> createDangerousSituations()
        {
            dangerous = new List<Char> { };
            dangerous.Add(Char.SHEEP | Char.CABBAGE);
            dangerous.Add(Char.WOLF | Char.SHEEP);
            return dangerous;
        }

        private void printSolution(List<Vertex> solution)
        {
            foreach (Vertex v in solution) {
                lblInfo.Text += v.Name + Environment.NewLine;
            }
        }

        private List<Char> retreiveTransportationTurns()
        {
            List<Vertex> moves = g.trace(g.getVertex(Char.NONE));

            List<Char> passangers = new List<Char>();
            for (int i = 0; i < moves.Count - 1; i++) {
                passangers.Add(moves[i].Chars ^ moves[i + 1].Chars);
            }

            return passangers;
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = false;
            var passangers = retreiveTransportationTurns();

            foreach (var turn in passangers) {
		        if (turn.HasFlag(Char.BOATMAN)) {
                    imageController.transfer(pbBoatman);
                } if (turn.HasFlag(Char.WOLF)) {
                    imageController.transfer(pbWolf);
                } if (turn.HasFlag(Char.SHEEP)) {
                    imageController.transfer(pbSheep);
                } if (turn.HasFlag(Char.CABBAGE)) {
                    imageController.transfer(pbCabbage);
                }
                await TaskEx.Delay(1000);
            }

            btnNext.Enabled = true;
        }
    }
}
