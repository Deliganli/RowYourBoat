namespace RowYourBoat
{
    partial class RowYourBoat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNext = new System.Windows.Forms.Button();
            this.pImages = new System.Windows.Forms.Panel();
            this.pbBoatman = new System.Windows.Forms.PictureBox();
            this.pbWolf = new System.Windows.Forms.PictureBox();
            this.pbSheep = new System.Windows.Forms.PictureBox();
            this.pbCabbage = new System.Windows.Forms.PictureBox();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.pImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoatman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWolf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSheep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCabbage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(682, 354);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(86, 41);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Demonstrate";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pImages
            // 
            this.pImages.Controls.Add(this.pbCabbage);
            this.pImages.Controls.Add(this.pbBoatman);
            this.pImages.Controls.Add(this.pbWolf);
            this.pImages.Controls.Add(this.pbSheep);
            this.pImages.Controls.Add(this.pbBackground);
            this.pImages.Location = new System.Drawing.Point(12, 12);
            this.pImages.Name = "pImages";
            this.pImages.Size = new System.Drawing.Size(756, 336);
            this.pImages.TabIndex = 14;
            // 
            // pbBoatman
            // 
            this.pbBoatman.Image = global::RowYourBoat.Properties.Resources.boat_and_boatman;
            this.pbBoatman.Location = new System.Drawing.Point(210, 214);
            this.pbBoatman.Name = "pbBoatman";
            this.pbBoatman.Size = new System.Drawing.Size(142, 98);
            this.pbBoatman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBoatman.TabIndex = 4;
            this.pbBoatman.TabStop = false;
            // 
            // pbWolf
            // 
            this.pbWolf.Image = global::RowYourBoat.Properties.Resources.coyote;
            this.pbWolf.Location = new System.Drawing.Point(23, 168);
            this.pbWolf.Name = "pbWolf";
            this.pbWolf.Size = new System.Drawing.Size(67, 96);
            this.pbWolf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWolf.TabIndex = 1;
            this.pbWolf.TabStop = false;
            // 
            // pbSheep
            // 
            this.pbSheep.Image = global::RowYourBoat.Properties.Resources.roadrunner;
            this.pbSheep.Location = new System.Drawing.Point(96, 199);
            this.pbSheep.Name = "pbSheep";
            this.pbSheep.Size = new System.Drawing.Size(63, 65);
            this.pbSheep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSheep.TabIndex = 3;
            this.pbSheep.TabStop = false;
            // 
            // pbCabbage
            // 
            this.pbCabbage.Image = global::RowYourBoat.Properties.Resources.seed;
            this.pbCabbage.Location = new System.Drawing.Point(165, 214);
            this.pbCabbage.Name = "pbCabbage";
            this.pbCabbage.Size = new System.Drawing.Size(60, 50);
            this.pbCabbage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCabbage.TabIndex = 2;
            this.pbCabbage.TabStop = false;
            // 
            // pbBackground
            // 
            this.pbBackground.Image = global::RowYourBoat.Properties.Resources.river;
            this.pbBackground.Location = new System.Drawing.Point(3, 3);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(750, 330);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackground.TabIndex = 6;
            this.pbBackground.TabStop = false;
            // 
            // RowYourBoat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 538);
            this.Controls.Add(this.pImages);
            this.Controls.Add(this.btnNext);
            this.Name = "RowYourBoat";
            this.Text = "Row Your Boat";
            this.Load += new System.EventHandler(this.RowYourBoat_Load);
            this.pImages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBoatman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWolf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSheep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCabbage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.PictureBox pbSheep;
        private System.Windows.Forms.PictureBox pbCabbage;
        private System.Windows.Forms.PictureBox pbWolf;
        private System.Windows.Forms.PictureBox pbBoatman;
        private System.Windows.Forms.Panel pImages;
    }
}

