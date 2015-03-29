using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RowYourBoat
{
    public class Edge
    {
        public Vertex Destination;
        public string Name;
        public int Cost;

        public Edge(Vertex destination, int cost, string name)
        {
            Destination = destination;
            Cost = cost;
            Name = name;
        }

    }

    public class Vertex
    {
        public string Name;
        public string Status;
        public List<Edge> Adjacents;
        public List<Edge> rAdjacents;
        public int Straight;
        public Vertex Parent;
        public Edge Road;

        public Vertex(string name, string status = "unchecked", int straight = int.MaxValue)
        {
            Name = name;
            Status = status;
            Parent = null;
            Adjacents = new List<Edge>();
            rAdjacents = new List<Edge>();
            Straight = straight;
        }
    }

    public class Graph
    {
        private readonly Dictionary<string, Vertex> vertexmap = new Dictionary<string, Vertex>();

        public void AddEdge(Char source, Char dest, int cost, string name)
        {
            Vertex v = GetVertex(source.ToString());
            Vertex w = GetVertex(dest.ToString());
            v.Adjacents.Add(new Edge(w, cost, name));
            w.rAdjacents.Add(new Edge(v, cost, name));
        }

        public Vertex GetVertex(string vertexname)
        {
            Vertex v;
            vertexmap.TryGetValue(vertexname, out v);
            if (v == null)
            {
                v = new Vertex(vertexname);
                vertexmap.Add(vertexname, v);
            }
            return v;
        }

        public List<Vertex> traceVertex(Vertex source, Vertex dest)
        {
            List<Vertex> q = new List<Vertex>();
            q.Add(dest);
            int i = 0;

            try
            {
                do
                {
                    q.Add(q[i++].Parent);
                } while (q[i] != source);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


            //from source to destination
            q.Reverse();
            return q;
        }

        public List<Edge> tracePath(Vertex source, Vertex dest)
        {
            List<Edge> q = new List<Edge>();

            try
            {
                do
                {
                    q.Add(dest.Road);
                    dest = dest.Parent;
                } while (dest != source);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            //from source to destination
            q.Reverse();
            return q;
        }
    }
}
