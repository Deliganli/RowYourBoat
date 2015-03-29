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
        List<Char> dangerous;        

        public RowYourBoat()
        {
            InitializeComponent();
        }

        private void createDangerousSituations()
        {
            dangerous = new List<Char> { };
            dangerous.Add(Char.SHEEP | Char.CABBAGE);
            dangerous.Add(Char.WOLF | Char.SHEEP);
        }

        private void transport(ref List<Char> from, ref List<Char> to, Char character)
        {
            if (character != Char.BOATMAN)
            {
                from.Remove(character);
                to.Add(character);
            }

            from.Remove(Char.BOATMAN);
            to.Add(Char.BOATMAN);
        }

        private void solveProblem(List<Char> from, List<Char> to, Stack<Char> moves)
        {
            Char current = from.First();
            transport(ref from, ref to, current);
            Console.WriteLine(current + " transport attemp");

            if (isDangerous(from)) {
                transport(ref to, ref from, current);
                Console.WriteLine(current + " rollback");
                solveProblem(from, to, moves);
            }
            else if (isDangerous(to)) {
                transport(ref from, ref to, current);
                Console.WriteLine(current + " rollback");
                solveProblem(to, from, moves);
            } else {
                Console.WriteLine("next iteration");
                to.Reverse();
                solveProblem(to, from, moves);
            }
        }

        private bool isDangerous(IEnumerable<Char> shore)
        {
            var current = shore.Aggregate(new Char(), (a, c) => a | c);
            return dangerous.Any(situation => current.HasFlag(situation) && !current.HasFlag(Char.BOATMAN));
        }

        private void RowYourBoat_Load(object sender, EventArgs e)
        {
            lblInfo.Text = String.Empty;
            lblPath.Text = String.Empty;
            lblCost.Text = String.Empty;

            createDangerousSituations();
            List<Char> leftShore = new List<Char> { 
                Char.WOLF, 
                Char.SHEEP, 
                Char.CABBAGE,
                Char.BOATMAN};
            List<Char> rightShore = new List<Char> { };
            Stack<Char> moves = new Stack<Char> { };

            //moves.Push(Characters.BOATMAN);
            //bool res = isDangerous(leftShore);
            //solveProblem(leftShore, rightShore, moves);

            Graph g = new Graph();
            createTree(g);
            Vertex start = g.GetVertex((Char.BOATMAN | Char.WOLF | Char.SHEEP | Char.CABBAGE).ToString());
            Vertex end = g.GetVertex(Char.NONE.ToString());
            Queue<Vertex> result = BFS.solve(start, end);
        }

        private void printingSteps(Vertex vSource, Vertex vDest, Graph g)
        {
            List<Vertex> stops = g.traceVertex(vSource, vDest);
            List<Edge> path = g.tracePath(vSource, vDest);
            try
            {
                for (int i = 1; i < stops.Count; i++)
                {
                    lblInfo.Text = lblInfo.Text + stops[i].Name + Environment.NewLine;
                }

                int costTotal = 0;

                for (int i = 0; i < path.Count; i++)
                {
                    lblPath.Text = lblPath.Text + path[i].Name + Environment.NewLine;
                    costTotal = costTotal + path[i].Cost;
                }

                lblCost.Text = costTotal.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
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
