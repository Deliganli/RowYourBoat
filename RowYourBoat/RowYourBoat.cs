using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RowYourBoat;

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
            lblPath.Text = String.Empty;
            lblCost.Text = String.Empty;

            Graph g = new Graph();
            createTree(g);
            Vertex start = g.GetVertex((Char.BOATMAN | Char.WOLF | Char.SHEEP | Char.CABBAGE).ToString());
            Vertex end = g.GetVertex(Char.NONE.ToString());
            Queue<Vertex> result = BFS.solve(start, end);
        }

        private void createTree(Graph g)
        {
            g.AddEdge(Char.BOATMAN | Char.WOLF | Char.SHEEP | Char.CABBAGE,
                Char.CABBAGE | Char.WOLF, 1, "1");
            g.AddEdge(Char.CABBAGE | Char.WOLF,
                Char.BOATMAN | Char.CABBAGE | Char.WOLF, 1, "2");
            g.AddEdge(Char.BOATMAN | Char.CABBAGE | Char.WOLF,
                Char.WOLF, 1, "3");
            g.AddEdge(Char.BOATMAN | Char.CABBAGE | Char.WOLF,
                Char.CABBAGE, 1, "4");
            g.AddEdge(Char.WOLF,
                Char.BOATMAN | Char.SHEEP | Char.WOLF, 1, "5");
            g.AddEdge(Char.BOATMAN | Char.SHEEP | Char.WOLF,
                Char.SHEEP, 1, "6");
            g.AddEdge(Char.CABBAGE,
                Char.BOATMAN | Char.CABBAGE | Char.SHEEP, 1, "7");
            g.AddEdge(Char.BOATMAN | Char.CABBAGE | Char.SHEEP,
                Char.SHEEP, 1, "8");
            g.AddEdge(Char.SHEEP,
                Char.BOATMAN | Char.SHEEP, 1, "9");
            g.AddEdge(Char.BOATMAN | Char.SHEEP,
                Char.NONE, 1, "10");
        }

    }
}
