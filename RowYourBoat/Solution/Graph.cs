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

        public Edge(Vertex destination, string name)
        {
            Destination = destination;
            Name = name;
        }

    }

    public class Vertex
    {
        public string Name;
        public string Status;
        public string Situation;
        public List<Edge> Adjacents;
        public Vertex Parent;
        public Char Chars;

        public Vertex(Char chars, string status = "UNCHECKED")
        {
            Name = chars.ToString();
            Chars = chars;
            Status = status;
            Situation = Constants.UNCHECKED;
            Parent = null;
            Adjacents = new List<Edge>();
        }
    }

    public class Graph
    {
        private readonly Dictionary<string, Vertex> vertexmap = new Dictionary<string, Vertex>();

        public void addEdge(Char source, Char dest, string name)
        {
            Vertex v = getVertex(source);
            Vertex w = getVertex(dest);
            v.Adjacents.Add(new Edge(w, name));
        }

        public Vertex getVertex(Char vertexname)
        {
            Vertex v;
            vertexmap.TryGetValue(vertexname.ToString(), out v);
            if (v == null)
            {
                v = new Vertex(vertexname);
                vertexmap.Add(vertexname.ToString(), v);
            }
            return v;
        }

        public List<Vertex> trace(Vertex dest)
        {
            List<Vertex> list = new List<Vertex>() { dest };

            do {
                list.Add(dest.Parent);
                dest = dest.Parent;
            } while (dest.Parent != null);

            list.Reverse();
            return list;
        }
    }
}
