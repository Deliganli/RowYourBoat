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
        public RowYourBoat()
        {
            InitializeComponent();
        }

        private void RowYourBoat_Load(object sender, EventArgs e)
        {
            lblInfo.Text = String.Empty;

            Graph g = new Graph();
            createTree(g);
            Vertex start = g.getVertex((Char.BOATMAN | Char.WOLF | Char.SHEEP | Char.CABBAGE).ToString());
            Vertex end = g.getVertex(Char.NONE.ToString());
            BFS.solve(start, end);
            printSolution(g.trace(end));
            inflatePictures();
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

        private void createTree(Graph g)
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
