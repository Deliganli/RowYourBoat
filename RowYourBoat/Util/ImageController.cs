using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RowYourBoat;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace RowYourBoat
{
    class ImageController
    {
        private PictureBox pbWolf;
        private PictureBox pbSheep;
        private PictureBox pbCabbage;
        private PictureBox pbBoatman;
        private PictureBox pbBackground;

        private Panel pImages;

        public ImageController(PictureBox wolf, PictureBox sheep, PictureBox cabbage,
                            PictureBox boatman, PictureBox background, Panel images)
        {
            this.pbWolf = wolf;
            this.pbSheep = sheep;
            this.pbCabbage = cabbage;
            this.pbBoatman = boatman;
            this.pbBackground = background;
            this.pImages = images;
            makeTransparent();
        }

        private void makeTransparent()
        {
            pbBackground.Controls.Add(pbWolf);
            pbBackground.Controls.Add(pbSheep);
            pbBackground.Controls.Add(pbCabbage);
            pbBackground.Controls.Add(pbBoatman);
            pbWolf.BackColor = Color.Transparent;
            pbSheep.BackColor = Color.Transparent;
            pbCabbage.BackColor = Color.Transparent;
            pbBoatman.BackColor = Color.Transparent;
        }

        public void transfer(PictureBox pb)
        {
            bool isLeft = isAtLeft(pb);
            pb.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            move(pb, isLeft);
        }

        private bool isAtLeft(PictureBox pb)
        {
            return pb.Left - pImages.Left <= pImages.Right - pb.Right;
        }

        private void move(PictureBox pb, bool direction)
        {
            if (direction) {
                int leftDistance = pb.Left - pImages.Left;
                pb.Left = pImages.Right - leftDistance - pb.Width;
            } else {
                int rightDistance = pImages.Right - pb.Right;
                pb.Left = pImages.Left + rightDistance;
            }
        }

    }
}
