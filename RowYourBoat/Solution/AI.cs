using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RowYourBoat.Solution
{
    class AI
    {
        public Graph createTree(Label lbl)
        {
            Graph g = new Graph();
            List<Char> dangerous = createDangerousSituations();

            Queue<Char> nodes = new Queue<Char>();
            Char positions = new List<Char>() { Char.CABBAGE, Char.SHEEP, Char.WOLF, Char.BOATMAN }
                .Aggregate(new Char(), (a, c) => a | c);
            nodes.Enqueue(positions);

            List<Char> previousNodes = new List<Char>();
            previousNodes.Add(positions);
            int i = 0;
            bool isBoatmanAtLeft = true;

            while (nodes.Count > 0)
            {
                Char current = nodes.Dequeue();
                isBoatmanAtLeft = current.HasFlag(Char.BOATMAN);

                var available = Enum.GetValues(typeof(Char)).Cast<Enum>();
                foreach (Char actor in available.Where((isBoatmanAtLeft ? current : ~current).HasFlag))
                {
                    if (actor == Char.NONE) {
                        continue;
                    }
                    Char afterTransfer = transfer(actor, current, isBoatmanAtLeft);

                    if (isDangerous(dangerous, afterTransfer, isBoatmanAtLeft)) {
                        lbl.Text += afterTransfer.ToString() + " is " + Constants.DANGEROUS + "---";
                    } else if (isRepeated(afterTransfer, previousNodes)) {
                        lbl.Text += afterTransfer.ToString() + " is " + Constants.REPEATED + "---";
                    } else if (isGoal(afterTransfer)) {
                        g.addEdge(current, afterTransfer, i++.ToString());
                        lbl.Text += afterTransfer.ToString() + " is " + "GOAL" + "---";
                        return g;
                    } else {
                        g.addEdge(current, afterTransfer, i++.ToString());
                        previousNodes.Add(afterTransfer);
                        nodes.Enqueue(afterTransfer);
                        lbl.Text += afterTransfer.ToString() + " is " + Constants.UNCHECKED + "---";
                    }
                }
                lbl.Text += Environment.NewLine;
            }

            return g;
        }

        private List<Char> createDangerousSituations()
        {
            List<Char> dangerous = new List<Char> { };
            dangerous.Add(Char.SHEEP | Char.CABBAGE);
            dangerous.Add(Char.WOLF | Char.SHEEP);
            return dangerous;
        }

        private Char transfer(Char actor, Char positions, bool isBoatmanAtLeft)
        {
            if (!(actor == Char.BOATMAN)) {
                positions = transfer(Char.BOATMAN, positions, isBoatmanAtLeft);
            }

            if (isBoatmanAtLeft) {
                return positions ^ actor;
            } else {
                return positions | actor;
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

        private bool isDangerous(List<Char> dangerous, Char current, bool a)
        {
            Char currentRelativeToBoatman = a ? current : ~current;
            return dangerous.Any(situation =>
                currentRelativeToBoatman.HasFlag(situation) &&
                !currentRelativeToBoatman.HasFlag(Char.BOATMAN));
        }
    }
}
