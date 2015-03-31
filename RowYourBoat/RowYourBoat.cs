using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RowYourBoat.Tree;

namespace RowYourBoat
{
    public partial class RowYourBoat : Form
    {
        List<Char> dangerous;

        public RowYourBoat()
        {
            InitializeComponent();
        }

        private void RowYourBoat_Load(object sender, EventArgs e)
        {
            lblInfo.Text = String.Empty;
            createDangerousSituations();

            Graph g = new Graph();
            //createTreeManually(g);
            createTreeProgrammatically(g);
            Vertex start = g.getVertex((Char.BOATMAN | Char.WOLF | Char.SHEEP | Char.CABBAGE).ToString());
            Vertex end = g.getVertex(Char.NONE.ToString());
            BFS.solve(start, end);
            printSolution(g.trace(end));
            inflatePictures();
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

                // TODO - Let graph can create same name nodes
                
                var available = Enum.GetValues(typeof(Char)).Cast<Enum>();
                foreach (Char actor in available.Where((isBoatmanAtLeft ? current : ~current).HasFlag))
                {
                    if (actor == Char.NONE)
                    {
                        continue;
                    }

                    Char afterTransfer = transfer(actor, current, isBoatmanAtLeft);
                    if (!(actor == Char.BOATMAN))
                    {
                        afterTransfer = transfer(Char.BOATMAN, afterTransfer, isBoatmanAtLeft);
                    }

                    if (isDangerous(afterTransfer)) {
                        g.addEdge(current, afterTransfer, i++.ToString());
                        g.getVertex(afterTransfer.ToString()).Status = Constants.DANGEROUS;
                    } else if (isRepeated(afterTransfer, previousNodes)) {
                        g.addEdge(current, afterTransfer, i++.ToString());
                        g.getVertex(afterTransfer.ToString()).Status = Constants.REPEATED;
                    } else if (isGoal(afterTransfer)) {
                        g.addEdge(current, afterTransfer, i++.ToString());
                        return;
                    } else {
                        g.addEdge(current, afterTransfer, i++.ToString());
                        previousNodes.Add(afterTransfer);
                        nodes.Enqueue(afterTransfer);
                    }
                }

                isBoatmanAtLeft = !isBoatmanAtLeft;
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

        private Char transfer(Char actor, Char positions, bool isBoatmanAtLeft){
            if (isBoatmanAtLeft)
            {
                return positions ^ actor;
            } else {
                return positions | actor;
            }
        }

        private void createDangerousSituations()
        {
            dangerous = new List<Char> { };
            dangerous.Add(Char.SHEEP | Char.CABBAGE);
            dangerous.Add(Char.WOLF | Char.SHEEP);
        }

        private bool isDangerous(Char current)
        {
            return dangerous.Any(situation => current.HasFlag(situation) && !current.HasFlag(Char.BOATMAN));
        }

        private void inflatePictures()
        {
            pbWolf.ImageLocation = "../coyote.png";
            pbWolf.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void printSolution(List<Vertex> solution)
        {
            foreach (Vertex v in solution)
            {
                lblInfo.Text += v.Name + Environment.NewLine;
            }
        }

        private void createTreeManually(Graph g)
        {
            g.addEdge(Char.BOATMAN | Char.WOLF | Char.SHEEP | Char.CABBAGE,
                Char.CABBAGE | Char.WOLF, "1");
            g.addEdge(Char.CABBAGE | Char.WOLF,
                Char.BOATMAN | Char.CABBAGE | Char.WOLF, "2");
            g.addEdge(Char.BOATMAN | Char.CABBAGE | Char.WOLF,
                Char.WOLF, "3");
            g.addEdge(Char.BOATMAN | Char.CABBAGE | Char.WOLF,
                Char.CABBAGE, "4");
            g.addEdge(Char.WOLF,
                Char.BOATMAN | Char.SHEEP | Char.WOLF, "5");
            g.addEdge(Char.BOATMAN | Char.SHEEP | Char.WOLF,
                Char.SHEEP, "6");
            g.addEdge(Char.CABBAGE,
                Char.BOATMAN | Char.CABBAGE | Char.SHEEP, "7");
            g.addEdge(Char.BOATMAN | Char.CABBAGE | Char.SHEEP,
                Char.SHEEP, "8");
            g.addEdge(Char.SHEEP,
                Char.BOATMAN | Char.SHEEP, "9");
            g.addEdge(Char.BOATMAN | Char.SHEEP,
                Char.NONE, "10");
        }

    }
}
