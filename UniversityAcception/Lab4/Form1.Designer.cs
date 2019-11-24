namespace Lab4
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
            this.gpaLbl = new System.Windows.Forms.Label();
            this.tstScoreLbl = new System.Windows.Forms.Label();
            this.gpaTxtBox = new System.Windows.Forms.TextBox();
            this.tstScoreTxtBox = new System.Windows.Forms.TextBox();
            this.calcBttn = new System.Windows.Forms.Button();
            this.resultsLbl = new System.Windows.Forms.Label();
            this.resultsOutputLbl = new System.Windows.Forms.Label();
            this.accptCountLbl = new System.Windows.Forms.Label();
            this.accptOutputLbl = new System.Windows.Forms.Label();
            this.rejectedCountLbl = new System.Windows.Forms.Label();
            this.rjctOutPutLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gpaLbl
            // 
            this.gpaLbl.AutoSize = true;
            this.gpaLbl.Location = new System.Drawing.Point(16, 31);
            this.gpaLbl.Name = "gpaLbl";
            this.gpaLbl.Size = new System.Drawing.Size(60, 13);
            this.gpaLbl.TabIndex = 0;
            this.gpaLbl.Text = "Enter GPA:";
            // 
            // tstScoreLbl
            // 
            this.tstScoreLbl.AutoSize = true;
            this.tstScoreLbl.Location = new System.Drawing.Point(16, 59);
            this.tstScoreLbl.Name = "tstScoreLbl";
            this.tstScoreLbl.Size = new System.Drawing.Size(133, 13);
            this.tstScoreLbl.TabIndex = 1;
            this.tstScoreLbl.Text = "Enter admission test score:";
            // 
            // gpaTxtBox
            // 
            this.gpaTxtBox.Location = new System.Drawing.Point(155, 28);
            this.gpaTxtBox.Name = "gpaTxtBox";
            this.gpaTxtBox.Size = new System.Drawing.Size(100, 20);
            this.gpaTxtBox.TabIndex = 2;
            // 
            // tstScoreTxtBox
            // 
            this.tstScoreTxtBox.Location = new System.Drawing.Point(155, 56);
            this.tstScoreTxtBox.Name = "tstScoreTxtBox";
            this.tstScoreTxtBox.Size = new System.Drawing.Size(100, 20);
            this.tstScoreTxtBox.TabIndex = 3;
            // 
            // calcBttn
            // 
            this.calcBttn.Location = new System.Drawing.Point(98, 98);
            this.calcBttn.Name = "calcBttn";
            this.calcBttn.Size = new System.Drawing.Size(75, 23);
            this.calcBttn.TabIndex = 4;
            this.calcBttn.Text = "Calculate";
            this.calcBttn.UseVisualStyleBackColor = true;
            this.calcBttn.Click += new System.EventHandler(this.calcBttn_Click);
            // 
            // resultsLbl
            // 
            this.resultsLbl.AutoSize = true;
            this.resultsLbl.Location = new System.Drawing.Point(17, 146);
            this.resultsLbl.Name = "resultsLbl";
            this.resultsLbl.Size = new System.Drawing.Size(83, 13);
            this.resultsLbl.TabIndex = 5;
            this.resultsLbl.Text = "You have been:";
            // 
            // resultsOutputLbl
            // 
            this.resultsOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultsOutputLbl.Location = new System.Drawing.Point(155, 145);
            this.resultsOutputLbl.Name = "resultsOutputLbl";
            this.resultsOutputLbl.Size = new System.Drawing.Size(83, 24);
            this.resultsOutputLbl.TabIndex = 6;
            // 
            // accptCountLbl
            // 
            this.accptCountLbl.AutoSize = true;
            this.accptCountLbl.Location = new System.Drawing.Point(16, 183);
            this.accptCountLbl.Name = "accptCountLbl";
            this.accptCountLbl.Size = new System.Drawing.Size(82, 13);
            this.accptCountLbl.TabIndex = 7;
            this.accptCountLbl.Text = "Total accepted:";
            // 
            // accptOutputLbl
            // 
            this.accptOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accptOutputLbl.Location = new System.Drawing.Point(155, 182);
            this.accptOutputLbl.Name = "accptOutputLbl";
            this.accptOutputLbl.Size = new System.Drawing.Size(83, 23);
            this.accptOutputLbl.TabIndex = 8;
            // 
            // rejectedCountLbl
            // 
            this.rejectedCountLbl.AutoSize = true;
            this.rejectedCountLbl.Location = new System.Drawing.Point(16, 216);
            this.rejectedCountLbl.Name = "rejectedCountLbl";
            this.rejectedCountLbl.Size = new System.Drawing.Size(75, 13);
            this.rejectedCountLbl.TabIndex = 9;
            this.rejectedCountLbl.Text = "Total rejected:";
            // 
            // rjctOutPutLbl
            // 
            this.rjctOutPutLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rjctOutPutLbl.Location = new System.Drawing.Point(155, 215);
            this.rjctOutPutLbl.Name = "rjctOutPutLbl";
            this.rjctOutPutLbl.Size = new System.Drawing.Size(83, 22);
            this.rjctOutPutLbl.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rjctOutPutLbl);
            this.Controls.Add(this.rejectedCountLbl);
            this.Controls.Add(this.accptOutputLbl);
            this.Controls.Add(this.accptCountLbl);
            this.Controls.Add(this.resultsOutputLbl);
            this.Controls.Add(this.resultsLbl);
            this.Controls.Add(this.calcBttn);
            this.Controls.Add(this.tstScoreTxtBox);
            this.Controls.Add(this.gpaTxtBox);
            this.Controls.Add(this.tstScoreLbl);
            this.Controls.Add(this.gpaLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gpaLbl;
        private System.Windows.Forms.Label tstScoreLbl;
        private System.Windows.Forms.TextBox gpaTxtBox;
        private System.Windows.Forms.TextBox tstScoreTxtBox;
        private System.Windows.Forms.Button calcBttn;
        private System.Windows.Forms.Label resultsLbl;
        private System.Windows.Forms.Label resultsOutputLbl;
        private System.Windows.Forms.Label accptCountLbl;
        private System.Windows.Forms.Label accptOutputLbl;
        private System.Windows.Forms.Label rejectedCountLbl;
        private System.Windows.Forms.Label rjctOutPutLbl;
    }
}

