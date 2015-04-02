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

        private GroupBox gbImages;

        public ImageController(PictureBox wolf, PictureBox sheep, PictureBox cabbage,
                            PictureBox boatman, PictureBox boat, PictureBox background,
                            GroupBox images)
        {
            this.pbWolf = wolf;
            this.pbSheep = sheep;
            this.pbCabbage = cabbage;
            this.pbBoatman = boatman;
            this.pbBoat = boat;
            this.pbBackground = background;
            this.gbImages = images;
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
            pbBoat.SizeMode = sizeMode;
        }

        public void transfer(PictureBox pb)
        {
            bool isLeft = isAtLeft(pb);
            move(pb, isLeft);
        }

        private bool isAtLeft(PictureBox pb)
        {
            return pb.Left - gbImages.Left <= gbImages.Right - pb.Right;
        }

        private void move(PictureBox pb, bool direction)
        {
            if (direction) {
                int leftDistance = pb.Left - gbImages.Left;
                pb.Left = gbImages.Right - leftDistance - pb.Width;
            } else {
                int rightDistance = gbImages.Right - pb.Right;
                pb.Left = gbImages.Left + rightDistance;
            }
        }

    }
}
