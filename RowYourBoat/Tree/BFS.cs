﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowYourBoat
{
    class BFS
    {
        private static String DISCOVERED = "DISCOVERED";
        //Breadt First Search
        public static Queue<Vertex> solve(Vertex vSource, Vertex vDest)
        {
            Queue<Vertex> q = new Queue<Vertex>();
            q.Enqueue(vSource);
            vSource.Status = DISCOVERED;
            while (q.Count > 0)
            {
                Vertex current = q.Dequeue();

                foreach (Edge prime in current.Adjacents)
                {
                    if (prime.Destination.Status != DISCOVERED)
                    {
                        q.Enqueue(prime.Destination);
                        prime.Destination.Status = DISCOVERED;
                    }
                }
            }//end-while
            return q;
        }
    }
}