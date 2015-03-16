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

        private void solveProblem(List<Characters> leftShore, List<Characters> rightShore, Stack<Characters> moves)
        {
            Characters current = leftShore.First();
            moves.Push(current);
            rightShore.Add(current);
            leftShore.Remove(current);

            if (isDangerous(leftShore))
            {
                rightShore.Remove(current);
                leftShore.Add(current);
                solveProblem(leftShore, rightShore, moves);
            }
        }

        private bool isDangerous(List<Characters> shore){
            Characters current = new Characters();
            foreach(Characters character in shore){
                current |= character;
            }
            
            foreach (Characters situation in dangerous) {
                if (current.HasFlag(situation) && !current.HasFlag(Characters.BOATMAN))
                {
                    return true;
                }
            }

            return false;
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
            //solveProblem(leftShore, rightShore, moves);
        }

    }
}
