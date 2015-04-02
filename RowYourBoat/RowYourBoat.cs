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
using RowYourBoat.Solution;

namespace RowYourBoat
{
    public partial class RowYourBoat : Form
    {

        Graph g;

        ImageController imageController;

        public RowYourBoat()
        {
            InitializeComponent();
        }

        private void RowYourBoat_Load(object sender, EventArgs e)
        {
            lblInfo.Text += Environment.NewLine;
            imageController = new ImageController(pbWolf, pbSheep, pbCabbage, pbBoatman, pbBackground, pImages);
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

        private void btnBFS_Click(object sender, EventArgs e)
        {
            Vertex start = g.getVertex(Char.BOATMAN | Char.WOLF | Char.SHEEP | Char.CABBAGE);
            Vertex end = g.getVertex(Char.NONE);
            BFS.solve(start, end);
            demonstrate();
        }

        private void btnDFS_Click(object sender, EventArgs e)
        {
            Vertex start = g.getVertex(Char.BOATMAN | Char.WOLF | Char.SHEEP | Char.CABBAGE);
            Vertex end = g.getVertex(Char.NONE);
            DFS.solve(start, end);
            demonstrate();
        }

        private async void demonstrate()
        {
            btnBFS.Enabled = false;
            btnDFS.Enabled = false;
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
        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "Left Side:" + Environment.NewLine;
            AI ai = new AI();
            g = ai.createTree(lblInfo);
            btnBFS.Enabled = true;
            btnDFS.Enabled = true;
        }
    }
}
