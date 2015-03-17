using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RowYourBoat
{
    public partial class RowYourBoat : Form
    {
        List<Characters> dangerous;

        [Flags]
        public enum Characters
        {
            WOLF = 1,
            SHEEP = 2,
            CABBAGE = 4,
            BOATMAN = 8,
        }

        public RowYourBoat()
        {
            InitializeComponent();
        }

        private void createDangerousSituations()
        {
            dangerous = new List<Characters> { };
            dangerous.Add(Characters.SHEEP | Characters.CABBAGE);
            dangerous.Add(Characters.WOLF | Characters.SHEEP);
        }

        private void transport(ref List<Characters> from, ref List<Characters> to, Characters character) {
            if (character != Characters.BOATMAN)
            {
                from.Remove(character);
                to.Add(character);
            }

            from.Remove(Characters.BOATMAN);
            to.Add(Characters.BOATMAN);
        }

        private void solveProblem(List<Characters> from, List<Characters> to, Stack<Characters> moves)
        {
            Characters current = from.First();
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

        private bool isDangerous(IEnumerable<Characters> shore)
        {
            var current = shore.Aggregate(new Characters(), (a, c) => a | c);
            return dangerous.Any(situation => current.HasFlag(situation) && !current.HasFlag(Characters.BOATMAN));
        }

        private void RowYourBoat_Load(object sender, EventArgs e)
        {
            createDangerousSituations();
            List<Characters> leftShore = new List<Characters> { 
                Characters.WOLF, 
                Characters.SHEEP, 
                Characters.CABBAGE,
                Characters.BOATMAN};
            List<Characters> rightShore = new List<Characters> { };
            Stack<Characters> moves = new Stack<Characters> { };

            moves.Push(Characters.BOATMAN);
            bool res = isDangerous(leftShore);
            solveProblem(leftShore, rightShore, moves);
        }

    }
}
