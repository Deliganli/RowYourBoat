using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RowYourBoat.Tree
{
    class DFS
    {
        private static String DISCOVERED = "DISCOVERED";
        //Breadt First Search
        public static Stack<Vertex> solve(Vertex vSource, Vertex vDest)
        {
            Stack<Vertex> solution = new Stack<Vertex>();
            solution.Push(vSource);
            while (solution.Count > 0)
            {
                Vertex current = solution.Pop();
                if (current.Status != DISCOVERED)
                {
                    current.Status = DISCOVERED;
                    foreach (Edge prime in current.Adjacents)
                    {
                        solution.Push(prime.Destination);
                        prime.Destination.Parent = current;
                    }
                }
            }//end-while
            return solution;
        }
    }
}
