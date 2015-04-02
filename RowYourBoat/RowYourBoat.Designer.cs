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
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.pbSheep = new System.Windows.Forms.PictureBox();
            this.pbCabbage = new System.Windows.Forms.PictureBox();
            this.pbWolf = new System.Windows.Forms.PictureBox();
            this.pbBoatman = new System.Windows.Forms.PictureBox();
            this.pImages = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSheep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCabbage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWolf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoatman)).BeginInit();
            this.pImages.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(15, 351);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(35, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "lblInfo";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(682, 337);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(86, 41);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Demonstrate";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pbBackground
            // 
            this.pbBackground.Location = new System.Drawing.Point(3, 3);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(750, 305);
            this.pbBackground.TabIndex = 6;
            this.pbBackground.TabStop = false;
            // 
            // pbSheep
            // 
            this.pbSheep.Location = new System.Drawing.Point(19, 109);
            this.pbSheep.Name = "pbSheep";
            this.pbSheep.Size = new System.Drawing.Size(80, 91);
            this.pbSheep.TabIndex = 3;
            this.pbSheep.TabStop = false;
            // 
            // pbCabbage
            // 
            this.pbCabbage.Location = new System.Drawing.Point(19, 206);
            this.pbCabbage.Name = "pbCabbage";
            this.pbCabbage.Size = new System.Drawing.Size(80, 88);
            this.pbCabbage.TabIndex = 2;
            this.pbCabbage.TabStop = false;
            // 
            // pbWolf
            // 
            this.pbWolf.Location = new System.Drawing.Point(19, 10);
            this.pbWolf.Name = "pbWolf";
            this.pbWolf.Size = new System.Drawing.Size(80, 93);
            this.pbWolf.TabIndex = 1;
            this.pbWolf.TabStop = false;
            // 
            // pbBoatman
            // 
            this.pbBoatman.Location = new System.Drawing.Point(105, 84);
            this.pbBoatman.Name = "pbBoatman";
            this.pbBoatman.Size = new System.Drawing.Size(210, 145);
            this.pbBoatman.TabIndex = 4;
            this.pbBoatman.TabStop = false;
            // 
            // pImages
            // 
            this.pImages.Controls.Add(this.pbBoatman);
            this.pImages.Controls.Add(this.pbWolf);
            this.pImages.Controls.Add(this.pbSheep);
            this.pImages.Controls.Add(this.pbCabbage);
            this.pImages.Controls.Add(this.pbBackground);
            this.pImages.Location = new System.Drawing.Point(12, 12);
            this.pImages.Name = "pImages";
            this.pImages.Size = new System.Drawing.Size(756, 311);
            this.pImages.TabIndex = 14;
            // 
            // RowYourBoat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 468);
            this.Controls.Add(this.pImages);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblInfo);
            this.Name = "RowYourBoat";
            this.Text = "Row Your Boat";
            this.Load += new System.EventHandler(this.RowYourBoat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSheep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCabbage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWolf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoatman)).EndInit();
            this.pImages.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.PictureBox pbSheep;
        private System.Windows.Forms.PictureBox pbCabbage;
        private System.Windows.Forms.PictureBox pbWolf;
        private System.Windows.Forms.PictureBox pbBoatman;
        private System.Windows.Forms.Panel pImages;
    }
}

