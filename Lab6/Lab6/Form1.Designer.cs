namespace Lab6
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
            this.wordsLbl = new System.Windows.Forms.Label();
            this.inputTxtBox = new System.Windows.Forms.TextBox();
            this.calcBttn = new System.Windows.Forms.Button();
            this.outputLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wordsLbl
            // 
            this.wordsLbl.AutoSize = true;
            this.wordsLbl.Location = new System.Drawing.Point(13, 26);
            this.wordsLbl.Name = "wordsLbl";
            this.wordsLbl.Size = new System.Drawing.Size(147, 13);
            this.wordsLbl.TabIndex = 0;
            this.wordsLbl.Text = "Enter words typed per minute:";
            // 
            // inputTxtBox
            // 
            this.inputTxtBox.Location = new System.Drawing.Point(167, 26);
            this.inputTxtBox.Name = "inputTxtBox";
            this.inputTxtBox.Size = new System.Drawing.Size(100, 20);
            this.inputTxtBox.TabIndex = 1;
            // 
            // calcBttn
            // 
            this.calcBttn.Location = new System.Drawing.Point(83, 97);
            this.calcBttn.Name = "calcBttn";
            this.calcBttn.Size = new System.Drawing.Size(106, 23);
            this.calcBttn.TabIndex = 2;
            this.calcBttn.Text = "Calculate Grade";
            this.calcBttn.UseVisualStyleBackColor = true;
            this.calcBttn.Click += new System.EventHandler(this.calcBttn_Click);
            // 
            // outputLbl
            // 
            this.outputLbl.AutoSize = true;
            this.outputLbl.Location = new System.Drawing.Point(118, 156);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(0, 13);
            this.outputLbl.TabIndex = 3;
            // 
            // Form1
            // 
            this.AcceptButton = this.calcBttn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.outputLbl);
            this.Controls.Add(this.calcBttn);
            this.Controls.Add(this.inputTxtBox);
            this.Controls.Add(this.wordsLbl);
            this.Name = "Form1";
            this.Text = "Lab 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wordsLbl;
        private System.Windows.Forms.TextBox inputTxtBox;
        private System.Windows.Forms.Button calcBttn;
        private System.Windows.Forms.Label outputLbl;
    }
}

