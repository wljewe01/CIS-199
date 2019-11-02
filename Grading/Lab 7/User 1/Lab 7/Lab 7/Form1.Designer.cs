namespace Lab_7
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
            this.futValLbl = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.futValTxt = new System.Windows.Forms.TextBox();
            this.interestRateLbl = new System.Windows.Forms.Label();
            this.yearsLbl = new System.Windows.Forms.Label();
            this.presValLbl = new System.Windows.Forms.Label();
            this.presValTxt = new System.Windows.Forms.TextBox();
            this.yearsTxt = new System.Windows.Forms.TextBox();
            this.rateTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // futValLbl
            // 
            this.futValLbl.AutoSize = true;
            this.futValLbl.Location = new System.Drawing.Point(42, 27);
            this.futValLbl.Name = "futValLbl";
            this.futValLbl.Size = new System.Drawing.Size(97, 17);
            this.futValLbl.TabIndex = 0;
            this.futValLbl.Text = "Future Value: ";
            // 
            // calcButton
            // 
            this.calcButton.BackColor = System.Drawing.SystemColors.Control;
            this.calcButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.calcButton.Location = new System.Drawing.Point(130, 194);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(100, 31);
            this.calcButton.TabIndex = 1;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = false;
            this.calcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // futValTxt
            // 
            this.futValTxt.Location = new System.Drawing.Point(189, 24);
            this.futValTxt.Name = "futValTxt";
            this.futValTxt.Size = new System.Drawing.Size(133, 22);
            this.futValTxt.TabIndex = 2;
            // 
            // interestRateLbl
            // 
            this.interestRateLbl.AutoSize = true;
            this.interestRateLbl.Location = new System.Drawing.Point(42, 58);
            this.interestRateLbl.Name = "interestRateLbl";
            this.interestRateLbl.Size = new System.Drawing.Size(141, 17);
            this.interestRateLbl.TabIndex = 3;
            this.interestRateLbl.Text = "Annual Interest Rate:";
            // 
            // yearsLbl
            // 
            this.yearsLbl.AutoSize = true;
            this.yearsLbl.Location = new System.Drawing.Point(42, 95);
            this.yearsLbl.Name = "yearsLbl";
            this.yearsLbl.Size = new System.Drawing.Size(95, 17);
            this.yearsLbl.TabIndex = 4;
            this.yearsLbl.Text = "No. of Years: ";
            // 
            // presValLbl
            // 
            this.presValLbl.AutoSize = true;
            this.presValLbl.Location = new System.Drawing.Point(42, 138);
            this.presValLbl.Name = "presValLbl";
            this.presValLbl.Size = new System.Drawing.Size(101, 17);
            this.presValLbl.TabIndex = 5;
            this.presValLbl.Text = "Present Value:";
            // 
            // presValTxt
            // 
            this.presValTxt.Location = new System.Drawing.Point(189, 135);
            this.presValTxt.Name = "presValTxt";
            this.presValTxt.Size = new System.Drawing.Size(133, 22);
            this.presValTxt.TabIndex = 6;
            // 
            // yearsTxt
            // 
            this.yearsTxt.Location = new System.Drawing.Point(189, 92);
            this.yearsTxt.Name = "yearsTxt";
            this.yearsTxt.Size = new System.Drawing.Size(133, 22);
            this.yearsTxt.TabIndex = 7;
            // 
            // rateTxt
            // 
            this.rateTxt.Location = new System.Drawing.Point(189, 55);
            this.rateTxt.Name = "rateTxt";
            this.rateTxt.Size = new System.Drawing.Size(133, 22);
            this.rateTxt.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 253);
            this.Controls.Add(this.rateTxt);
            this.Controls.Add(this.yearsTxt);
            this.Controls.Add(this.presValTxt);
            this.Controls.Add(this.presValLbl);
            this.Controls.Add(this.yearsLbl);
            this.Controls.Add(this.interestRateLbl);
            this.Controls.Add(this.futValTxt);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.futValLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label futValLbl;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.TextBox futValTxt;
        private System.Windows.Forms.Label interestRateLbl;
        private System.Windows.Forms.Label yearsLbl;
        private System.Windows.Forms.Label presValLbl;
        private System.Windows.Forms.TextBox presValTxt;
        private System.Windows.Forms.TextBox yearsTxt;
        private System.Windows.Forms.TextBox rateTxt;
    }
}

