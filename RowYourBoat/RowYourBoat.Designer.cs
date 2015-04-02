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
            this.btnBFS = new System.Windows.Forms.Button();
            this.pImages = new System.Windows.Forms.Panel();
            this.pbCabbage = new System.Windows.Forms.PictureBox();
            this.pbBoatman = new System.Windows.Forms.PictureBox();
            this.pbWolf = new System.Windows.Forms.PictureBox();
            this.pbSheep = new System.Windows.Forms.PictureBox();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnDFS = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSpace = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCabbage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoatman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWolf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSheep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBFS
            // 
            this.btnBFS.Enabled = false;
            this.btnBFS.Location = new System.Drawing.Point(6, 19);
            this.btnBFS.Name = "btnBFS";
            this.btnBFS.Size = new System.Drawing.Size(86, 41);
            this.btnBFS.TabIndex = 7;
            this.btnBFS.Text = "Breadth-First Search";
            this.btnBFS.UseVisualStyleBackColor = true;
            this.btnBFS.Click += new System.EventHandler(this.btnBFS_Click);
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
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 354);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(52, 13);
            this.lblInfo.TabIndex = 15;
            this.lblInfo.Text = "Left Side:";
            // 
            // btnDFS
            // 
            this.btnDFS.Enabled = false;
            this.btnDFS.Location = new System.Drawing.Point(6, 66);
            this.btnDFS.Name = "btnDFS";
            this.btnDFS.Size = new System.Drawing.Size(86, 41);
            this.btnDFS.TabIndex = 16;
            this.btnDFS.Text = "Depth-First Search";
            this.btnDFS.UseVisualStyleBackColor = true;
            this.btnDFS.Click += new System.EventHandler(this.btnDFS_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBFS);
            this.groupBox1.Controls.Add(this.btnDFS);
            this.groupBox1.Location = new System.Drawing.Point(774, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 115);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solve with";
            // 
            // btnSpace
            // 
            this.btnSpace.Location = new System.Drawing.Point(6, 19);
            this.btnSpace.Name = "btnSpace";
            this.btnSpace.Size = new System.Drawing.Size(86, 41);
            this.btnSpace.TabIndex = 17;
            this.btnSpace.Text = "Create State Space";
            this.btnSpace.UseVisualStyleBackColor = true;
            this.btnSpace.Click += new System.EventHandler(this.btnSpace_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSpace);
            this.groupBox2.Location = new System.Drawing.Point(774, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(97, 67);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "State Space";
            // 
            // RowYourBoat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 538);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pImages);
            this.Name = "RowYourBoat";
            this.Text = "Row Your Boat";
            this.Load += new System.EventHandler(this.RowYourBoat_Load);
            this.pImages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCabbage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoatman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWolf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSheep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBFS;
        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.PictureBox pbSheep;
        private System.Windows.Forms.PictureBox pbCabbage;
        private System.Windows.Forms.PictureBox pbWolf;
        private System.Windows.Forms.PictureBox pbBoatman;
        private System.Windows.Forms.Panel pImages;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnDFS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSpace;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

