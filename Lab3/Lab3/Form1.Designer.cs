namespace Lab3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radiusLbl = new System.Windows.Forms.Label();
            this.radiusTxtBox = new System.Windows.Forms.TextBox();
            this.diameterLbl = new System.Windows.Forms.Label();
            this.surfaceAreaLbl = new System.Windows.Forms.Label();
            this.volumeLbl = new System.Windows.Forms.Label();
            this.diameterOutputLbl = new System.Windows.Forms.Label();
            this.surfaceAreaOutputLbl = new System.Windows.Forms.Label();
            this.volumeOutputLbl = new System.Windows.Forms.Label();
            this.calcBttn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // radiusLbl
            // 
            this.radiusLbl.AutoSize = true;
            this.radiusLbl.Location = new System.Drawing.Point(165, 45);
            this.radiusLbl.Name = "radiusLbl";
            this.radiusLbl.Size = new System.Drawing.Size(90, 13);
            this.radiusLbl.TabIndex = 0;
            this.radiusLbl.Text = "Radius of sphere:";
            // 
            // radiusTxtBox
            // 
            this.radiusTxtBox.Location = new System.Drawing.Point(260, 42);
            this.radiusTxtBox.Name = "radiusTxtBox";
            this.radiusTxtBox.Size = new System.Drawing.Size(100, 20);
            this.radiusTxtBox.TabIndex = 1;
            // 
            // diameterLbl
            // 
            this.diameterLbl.AutoSize = true;
            this.diameterLbl.Location = new System.Drawing.Point(39, 160);
            this.diameterLbl.Name = "diameterLbl";
            this.diameterLbl.Size = new System.Drawing.Size(49, 13);
            this.diameterLbl.TabIndex = 2;
            this.diameterLbl.Text = "Diameter";
            // 
            // surfaceAreaLbl
            // 
            this.surfaceAreaLbl.AutoSize = true;
            this.surfaceAreaLbl.Location = new System.Drawing.Point(39, 211);
            this.surfaceAreaLbl.Name = "surfaceAreaLbl";
            this.surfaceAreaLbl.Size = new System.Drawing.Size(69, 13);
            this.surfaceAreaLbl.TabIndex = 3;
            this.surfaceAreaLbl.Text = "Surface Area";
            // 
            // volumeLbl
            // 
            this.volumeLbl.AutoSize = true;
            this.volumeLbl.Location = new System.Drawing.Point(39, 259);
            this.volumeLbl.Name = "volumeLbl";
            this.volumeLbl.Size = new System.Drawing.Size(42, 13);
            this.volumeLbl.TabIndex = 4;
            this.volumeLbl.Text = "Volume";
            // 
            // diameterOutputLbl
            // 
            this.diameterOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diameterOutputLbl.Location = new System.Drawing.Point(130, 160);
            this.diameterOutputLbl.Name = "diameterOutputLbl";
            this.diameterOutputLbl.Size = new System.Drawing.Size(71, 24);
            this.diameterOutputLbl.TabIndex = 5;
            // 
            // surfaceAreaOutputLbl
            // 
            this.surfaceAreaOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surfaceAreaOutputLbl.Location = new System.Drawing.Point(130, 211);
            this.surfaceAreaOutputLbl.Name = "surfaceAreaOutputLbl";
            this.surfaceAreaOutputLbl.Size = new System.Drawing.Size(71, 22);
            this.surfaceAreaOutputLbl.TabIndex = 6;
            // 
            // volumeOutputLbl
            // 
            this.volumeOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.volumeOutputLbl.Location = new System.Drawing.Point(130, 259);
            this.volumeOutputLbl.Name = "volumeOutputLbl";
            this.volumeOutputLbl.Size = new System.Drawing.Size(71, 22);
            this.volumeOutputLbl.TabIndex = 7;
            // 
            // calcBttn
            // 
            this.calcBttn.Location = new System.Drawing.Point(272, 68);
            this.calcBttn.Name = "calcBttn";
            this.calcBttn.Size = new System.Drawing.Size(75, 23);
            this.calcBttn.TabIndex = 8;
            this.calcBttn.Text = "Calculate";
            this.calcBttn.UseVisualStyleBackColor = true;
            this.calcBttn.Click += new System.EventHandler(this.calcBttn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(222, 199);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.calcBttn);
            this.Controls.Add(this.volumeOutputLbl);
            this.Controls.Add(this.surfaceAreaOutputLbl);
            this.Controls.Add(this.diameterOutputLbl);
            this.Controls.Add(this.volumeLbl);
            this.Controls.Add(this.surfaceAreaLbl);
            this.Controls.Add(this.diameterLbl);
            this.Controls.Add(this.radiusTxtBox);
            this.Controls.Add(this.radiusLbl);
            this.Name = "Form1";
            this.Text = "Lab 3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label radiusLbl;
        private System.Windows.Forms.TextBox radiusTxtBox;
        private System.Windows.Forms.Label diameterLbl;
        private System.Windows.Forms.Label surfaceAreaLbl;
        private System.Windows.Forms.Label volumeLbl;
        private System.Windows.Forms.Label diameterOutputLbl;
        private System.Windows.Forms.Label surfaceAreaOutputLbl;
        private System.Windows.Forms.Label volumeOutputLbl;
        private System.Windows.Forms.Button calcBttn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

