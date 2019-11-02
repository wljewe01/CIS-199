namespace Program2
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
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.creditHoursLbl = new System.Windows.Forms.Label();
            this.lastNameTxtBox = new System.Windows.Forms.TextBox();
            this.creditHoursTxtBox = new System.Windows.Forms.TextBox();
            this.regLbl = new System.Windows.Forms.Label();
            this.outPutLbl = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.errorLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(12, 24);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(143, 13);
            this.lastNameLbl.TabIndex = 0;
            this.lastNameLbl.Text = "Enter first letter of last name: ";
            // 
            // creditHoursLbl
            // 
            this.creditHoursLbl.AutoSize = true;
            this.creditHoursLbl.Location = new System.Drawing.Point(62, 53);
            this.creditHoursLbl.Name = "creditHoursLbl";
            this.creditHoursLbl.Size = new System.Drawing.Size(93, 13);
            this.creditHoursLbl.TabIndex = 1;
            this.creditHoursLbl.Text = "Enter credit hours:";
            // 
            // lastNameTxtBox
            // 
            this.lastNameTxtBox.Location = new System.Drawing.Point(172, 21);
            this.lastNameTxtBox.Name = "lastNameTxtBox";
            this.lastNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTxtBox.TabIndex = 2;
            // 
            // creditHoursTxtBox
            // 
            this.creditHoursTxtBox.Location = new System.Drawing.Point(172, 50);
            this.creditHoursTxtBox.Name = "creditHoursTxtBox";
            this.creditHoursTxtBox.Size = new System.Drawing.Size(100, 20);
            this.creditHoursTxtBox.TabIndex = 3;
            // 
            // regLbl
            // 
            this.regLbl.AutoSize = true;
            this.regLbl.Location = new System.Drawing.Point(62, 143);
            this.regLbl.Name = "regLbl";
            this.regLbl.Size = new System.Drawing.Size(184, 13);
            this.regLbl.TabIndex = 4;
            this.regLbl.Text = "The earliest time for you to register is: ";
            // 
            // outPutLbl
            // 
            this.outPutLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outPutLbl.Location = new System.Drawing.Point(25, 165);
            this.outPutLbl.Name = "outPutLbl";
            this.outPutLbl.Size = new System.Drawing.Size(235, 23);
            this.outPutLbl.TabIndex = 5;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(103, 91);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 6;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // errorLbl
            // 
            this.errorLbl.Location = new System.Drawing.Point(62, 117);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(154, 23);
            this.errorLbl.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.outPutLbl);
            this.Controls.Add(this.regLbl);
            this.Controls.Add(this.creditHoursTxtBox);
            this.Controls.Add(this.lastNameTxtBox);
            this.Controls.Add(this.creditHoursLbl);
            this.Controls.Add(this.lastNameLbl);
            this.Name = "Form1";
            this.Text = "Program 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Label creditHoursLbl;
        private System.Windows.Forms.TextBox lastNameTxtBox;
        private System.Windows.Forms.TextBox creditHoursTxtBox;
        private System.Windows.Forms.Label regLbl;
        private System.Windows.Forms.Label outPutLbl;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label errorLbl;
    }
}

