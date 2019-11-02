namespace Lab7
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
            this.futureValLbl = new System.Windows.Forms.Label();
            this.annualIntLbl = new System.Windows.Forms.Label();
            this.numOfYearsLbl = new System.Windows.Forms.Label();
            this.prsntValueLbl = new System.Windows.Forms.Label();
            this.futureValInputTxtBox = new System.Windows.Forms.TextBox();
            this.intRateInputTxtBox = new System.Windows.Forms.TextBox();
            this.yearsInputTxtBox = new System.Windows.Forms.TextBox();
            this.prsntValOutputTxtBox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // futureValLbl
            // 
            this.futureValLbl.AutoSize = true;
            this.futureValLbl.Location = new System.Drawing.Point(23, 27);
            this.futureValLbl.Name = "futureValLbl";
            this.futureValLbl.Size = new System.Drawing.Size(73, 13);
            this.futureValLbl.TabIndex = 0;
            this.futureValLbl.Text = "Future Value: ";
            // 
            // annualIntLbl
            // 
            this.annualIntLbl.AutoSize = true;
            this.annualIntLbl.Location = new System.Drawing.Point(23, 61);
            this.annualIntLbl.Name = "annualIntLbl";
            this.annualIntLbl.Size = new System.Drawing.Size(107, 13);
            this.annualIntLbl.TabIndex = 1;
            this.annualIntLbl.Text = "Annual Interest Rate:";
            // 
            // numOfYearsLbl
            // 
            this.numOfYearsLbl.AutoSize = true;
            this.numOfYearsLbl.Location = new System.Drawing.Point(23, 89);
            this.numOfYearsLbl.Name = "numOfYearsLbl";
            this.numOfYearsLbl.Size = new System.Drawing.Size(64, 13);
            this.numOfYearsLbl.TabIndex = 2;
            this.numOfYearsLbl.Text = "No. of Year:";
            // 
            // prsntValueLbl
            // 
            this.prsntValueLbl.AutoSize = true;
            this.prsntValueLbl.Location = new System.Drawing.Point(23, 119);
            this.prsntValueLbl.Name = "prsntValueLbl";
            this.prsntValueLbl.Size = new System.Drawing.Size(76, 13);
            this.prsntValueLbl.TabIndex = 3;
            this.prsntValueLbl.Text = "Present Value:";
            // 
            // futureValInputTxtBox
            // 
            this.futureValInputTxtBox.Location = new System.Drawing.Point(154, 24);
            this.futureValInputTxtBox.Name = "futureValInputTxtBox";
            this.futureValInputTxtBox.Size = new System.Drawing.Size(100, 20);
            this.futureValInputTxtBox.TabIndex = 4;
            // 
            // intRateInputTxtBox
            // 
            this.intRateInputTxtBox.Location = new System.Drawing.Point(154, 58);
            this.intRateInputTxtBox.Name = "intRateInputTxtBox";
            this.intRateInputTxtBox.Size = new System.Drawing.Size(100, 20);
            this.intRateInputTxtBox.TabIndex = 5;
            // 
            // yearsInputTxtBox
            // 
            this.yearsInputTxtBox.Location = new System.Drawing.Point(154, 89);
            this.yearsInputTxtBox.Name = "yearsInputTxtBox";
            this.yearsInputTxtBox.Size = new System.Drawing.Size(100, 20);
            this.yearsInputTxtBox.TabIndex = 6;
            // 
            // prsntValOutputTxtBox
            // 
            this.prsntValOutputTxtBox.Location = new System.Drawing.Point(154, 119);
            this.prsntValOutputTxtBox.Name = "prsntValOutputTxtBox";
            this.prsntValOutputTxtBox.Size = new System.Drawing.Size(100, 20);
            this.prsntValOutputTxtBox.TabIndex = 7;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(108, 161);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 8;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.prsntValOutputTxtBox);
            this.Controls.Add(this.yearsInputTxtBox);
            this.Controls.Add(this.intRateInputTxtBox);
            this.Controls.Add(this.futureValInputTxtBox);
            this.Controls.Add(this.prsntValueLbl);
            this.Controls.Add(this.numOfYearsLbl);
            this.Controls.Add(this.annualIntLbl);
            this.Controls.Add(this.futureValLbl);
            this.Name = "Form1";
            this.Text = "Lab7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label futureValLbl;
        private System.Windows.Forms.Label annualIntLbl;
        private System.Windows.Forms.Label numOfYearsLbl;
        private System.Windows.Forms.Label prsntValueLbl;
        private System.Windows.Forms.TextBox futureValInputTxtBox;
        private System.Windows.Forms.TextBox intRateInputTxtBox;
        private System.Windows.Forms.TextBox yearsInputTxtBox;
        private System.Windows.Forms.TextBox prsntValOutputTxtBox;
        private System.Windows.Forms.Button calcButton;
    }
}

