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

            Graph g = new Graph();
            createTree(g);
            Vertex start = g.getVertex((Char.BOATMAN | Char.WOLF | Char.SHEEP | Char.CABBAGE).ToString());
            Vertex end = g.getVertex(Char.NONE.ToString());
            BFS.solve(start, end);
            printSolution(g.trace(end));
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
                Char.CABBAGE | Char.WOLF, 1, "1");
            g.addEdge(Char.CABBAGE | Char.WOLF,
                Char.BOATMAN | Char.CABBAGE | Char.WOLF, 1, "2");
            g.addEdge(Char.BOATMAN | Char.CABBAGE | Char.WOLF,
                Char.WOLF, 1, "3");
            g.addEdge(Char.BOATMAN | Char.CABBAGE | Char.WOLF,
                Char.CABBAGE, 1, "4");
            g.addEdge(Char.WOLF,
                Char.BOATMAN | Char.SHEEP | Char.WOLF, 1, "5");
            g.addEdge(Char.BOATMAN | Char.SHEEP | Char.WOLF,
                Char.SHEEP, 1, "6");
            g.addEdge(Char.CABBAGE,
                Char.BOATMAN | Char.CABBAGE | Char.SHEEP, 1, "7");
            g.addEdge(Char.BOATMAN | Char.CABBAGE | Char.SHEEP,
                Char.SHEEP, 1, "8");
            g.addEdge(Char.SHEEP,
                Char.BOATMAN | Char.SHEEP, 1, "9");
            g.addEdge(Char.BOATMAN | Char.SHEEP,
                Char.NONE, 1, "10");
        }

    }
}
