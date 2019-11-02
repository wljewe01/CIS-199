namespace Lab7
{
    partial class Lab7
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
            this.fvLbl = new System.Windows.Forms.Label();
            this.rateLbl = new System.Windows.Forms.Label();
            this.yearLbl = new System.Windows.Forms.Label();
            this.pvLbl = new System.Windows.Forms.Label();
            this.fvTxt = new System.Windows.Forms.TextBox();
            this.rateTxt = new System.Windows.Forms.TextBox();
            this.yearTxt = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.outputLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fvLbl
            // 
            this.fvLbl.AutoSize = true;
            this.fvLbl.Location = new System.Drawing.Point(40, 29);
            this.fvLbl.Name = "fvLbl";
            this.fvLbl.Size = new System.Drawing.Size(70, 13);
            this.fvLbl.TabIndex = 0;
            this.fvLbl.Text = "Future Value:";
            // 
            // rateLbl
            // 
            this.rateLbl.AutoSize = true;
            this.rateLbl.Location = new System.Drawing.Point(40, 67);
            this.rateLbl.Name = "rateLbl";
            this.rateLbl.Size = new System.Drawing.Size(107, 13);
            this.rateLbl.TabIndex = 1;
            this.rateLbl.Text = "Annual Interest Rate:";
            // 
            // yearLbl
            // 
            this.yearLbl.AutoSize = true;
            this.yearLbl.Location = new System.Drawing.Point(40, 106);
            this.yearLbl.Name = "yearLbl";
            this.yearLbl.Size = new System.Drawing.Size(64, 13);
            this.yearLbl.TabIndex = 2;
            this.yearLbl.Text = "No. of Year:";
            // 
            // pvLbl
            // 
            this.pvLbl.AutoSize = true;
            this.pvLbl.Location = new System.Drawing.Point(40, 164);
            this.pvLbl.Name = "pvLbl";
            this.pvLbl.Size = new System.Drawing.Size(76, 13);
            this.pvLbl.TabIndex = 3;
            this.pvLbl.Text = "Present Value:";
            // 
            // fvTxt
            // 
            this.fvTxt.Location = new System.Drawing.Point(180, 26);
            this.fvTxt.Name = "fvTxt";
            this.fvTxt.Size = new System.Drawing.Size(100, 20);
            this.fvTxt.TabIndex = 4;
            // 
            // rateTxt
            // 
            this.rateTxt.Location = new System.Drawing.Point(180, 64);
            this.rateTxt.Name = "rateTxt";
            this.rateTxt.Size = new System.Drawing.Size(100, 20);
            this.rateTxt.TabIndex = 5;
            // 
            // yearTxt
            // 
            this.yearTxt.Location = new System.Drawing.Point(180, 103);
            this.yearTxt.Name = "yearTxt";
            this.yearTxt.Size = new System.Drawing.Size(100, 20);
            this.yearTxt.TabIndex = 6;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(109, 211);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 7;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // outputLbl
            // 
            this.outputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLbl.Location = new System.Drawing.Point(180, 163);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(100, 20);
            this.outputLbl.TabIndex = 8;
            // 
            // Lab7
            // 
            this.AcceptButton = this.calcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.outputLbl);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.yearTxt);
            this.Controls.Add(this.rateTxt);
            this.Controls.Add(this.fvTxt);
            this.Controls.Add(this.pvLbl);
            this.Controls.Add(this.yearLbl);
            this.Controls.Add(this.rateLbl);
            this.Controls.Add(this.fvLbl);
            this.Name = "Lab7";
            this.Text = "NPV Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fvLbl;
        private System.Windows.Forms.Label rateLbl;
        private System.Windows.Forms.Label yearLbl;
        private System.Windows.Forms.Label pvLbl;
        private System.Windows.Forms.TextBox fvTxt;
        private System.Windows.Forms.TextBox rateTxt;
        private System.Windows.Forms.TextBox yearTxt;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label outputLbl;
    }
}

