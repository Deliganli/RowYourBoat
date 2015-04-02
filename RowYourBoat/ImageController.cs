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
        private PictureBox pbBoat;
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
        }

        public void inflatePictures()
        {
            string basePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            pbCabbage.ImageLocation = basePath + "\\Resources\\seed.png";
            pbSheep.ImageLocation = basePath + "\\Resources\\roadrunner.png";
            pbWolf.ImageLocation = basePath + "\\Resources\\coyote.png";
            pbBoatman.ImageLocation = basePath + "\\Resources\\boat_and_boatman.png";
            this.setSizeModeForAll(PictureBoxSizeMode.StretchImage);
        }

        private void setSizeModeForAll(PictureBoxSizeMode sizeMode)
        {
            pbCabbage.SizeMode = sizeMode;
            pbSheep.SizeMode = sizeMode;
            pbWolf.SizeMode = sizeMode;
            pbBoatman.SizeMode = sizeMode;
        }

        public void transfer(PictureBox pb)
        {
            bool isLeft = isAtLeft(pb);
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
