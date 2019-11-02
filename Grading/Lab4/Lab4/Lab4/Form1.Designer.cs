namespace Lab4
{
    partial class LabForm
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
            this.testScoreLbl = new System.Windows.Forms.Label();
            this.gpaTxt = new System.Windows.Forms.TextBox();
            this.testScoreTxt = new System.Windows.Forms.TextBox();
            this.testButton = new System.Windows.Forms.Button();
            this.acceptLbl = new System.Windows.Forms.Label();
            this.rejectLbl = new System.Windows.Forms.Label();
            this.acceptCountLbl = new System.Windows.Forms.Label();
            this.rejectCountLbl = new System.Windows.Forms.Label();
            this.resultLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gpaLbl
            // 
            this.gpaLbl.AutoSize = true;
            this.gpaLbl.Location = new System.Drawing.Point(38, 34);
            this.gpaLbl.Name = "gpaLbl";
            this.gpaLbl.Size = new System.Drawing.Size(60, 13);
            this.gpaLbl.TabIndex = 0;
            this.gpaLbl.Text = "Enter GPA:";
            // 
            // testScoreLbl
            // 
            this.testScoreLbl.AutoSize = true;
            this.testScoreLbl.Location = new System.Drawing.Point(38, 61);
            this.testScoreLbl.Name = "testScoreLbl";
            this.testScoreLbl.Size = new System.Drawing.Size(84, 13);
            this.testScoreLbl.TabIndex = 1;
            this.testScoreLbl.Text = "Enter test score:";
            // 
            // gpaTxt
            // 
            this.gpaTxt.Location = new System.Drawing.Point(128, 27);
            this.gpaTxt.Name = "gpaTxt";
            this.gpaTxt.Size = new System.Drawing.Size(100, 20);
            this.gpaTxt.TabIndex = 2;
            // 
            // testScoreTxt
            // 
            this.testScoreTxt.Location = new System.Drawing.Point(128, 54);
            this.testScoreTxt.Name = "testScoreTxt";
            this.testScoreTxt.Size = new System.Drawing.Size(100, 20);
            this.testScoreTxt.TabIndex = 3;
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(107, 100);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(70, 23);
            this.testButton.TabIndex = 4;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // acceptLbl
            // 
            this.acceptLbl.AutoSize = true;
            this.acceptLbl.Location = new System.Drawing.Point(54, 172);
            this.acceptLbl.Name = "acceptLbl";
            this.acceptLbl.Size = new System.Drawing.Size(53, 13);
            this.acceptLbl.TabIndex = 5;
            this.acceptLbl.Text = "Accepted";
            // 
            // rejectLbl
            // 
            this.rejectLbl.AutoSize = true;
            this.rejectLbl.Location = new System.Drawing.Point(178, 172);
            this.rejectLbl.Name = "rejectLbl";
            this.rejectLbl.Size = new System.Drawing.Size(50, 13);
            this.rejectLbl.TabIndex = 6;
            this.rejectLbl.Text = "Rejected";
            // 
            // acceptCountLbl
            // 
            this.acceptCountLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.acceptCountLbl.Location = new System.Drawing.Point(64, 187);
            this.acceptCountLbl.Name = "acceptCountLbl";
            this.acceptCountLbl.Size = new System.Drawing.Size(35, 20);
            this.acceptCountLbl.TabIndex = 7;
            // 
            // rejectCountLbl
            // 
            this.rejectCountLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rejectCountLbl.Location = new System.Drawing.Point(186, 187);
            this.rejectCountLbl.Name = "rejectCountLbl";
            this.rejectCountLbl.Size = new System.Drawing.Size(35, 20);
            this.rejectCountLbl.TabIndex = 8;
            // 
            // resultLbl
            // 
            this.resultLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultLbl.Location = new System.Drawing.Point(107, 126);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(70, 20);
            this.resultLbl.TabIndex = 9;
            // 
            // LabForm
            // 
            this.AcceptButton = this.testButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.rejectCountLbl);
            this.Controls.Add(this.acceptCountLbl);
            this.Controls.Add(this.rejectLbl);
            this.Controls.Add(this.acceptLbl);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.testScoreTxt);
            this.Controls.Add(this.gpaTxt);
            this.Controls.Add(this.testScoreLbl);
            this.Controls.Add(this.gpaLbl);
            this.Name = "LabForm";
            this.Text = "Lab 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gpaLbl;
        private System.Windows.Forms.Label testScoreLbl;
        private System.Windows.Forms.TextBox gpaTxt;
        private System.Windows.Forms.TextBox testScoreTxt;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Label acceptLbl;
        private System.Windows.Forms.Label rejectLbl;
        private System.Windows.Forms.Label acceptCountLbl;
        private System.Windows.Forms.Label rejectCountLbl;
        private System.Windows.Forms.Label resultLbl;
    }
}

