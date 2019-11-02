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
            this.btnGrade = new System.Windows.Forms.Button();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblWordsTyped = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGrade
            // 
            this.btnGrade.Location = new System.Drawing.Point(71, 81);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(75, 23);
            this.btnGrade.TabIndex = 0;
            this.btnGrade.Text = "Grade";
            this.btnGrade.UseVisualStyleBackColor = true;
            this.btnGrade.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // lblGrade
            // 
            this.lblGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGrade.Location = new System.Drawing.Point(58, 123);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(100, 23);
            this.lblGrade.TabIndex = 1;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(58, 46);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 2;
            // 
            // lblWordsTyped
            // 
            this.lblWordsTyped.AutoSize = true;
            this.lblWordsTyped.Location = new System.Drawing.Point(55, 20);
            this.lblWordsTyped.Name = "lblWordsTyped";
            this.lblWordsTyped.Size = new System.Drawing.Size(123, 13);
            this.lblWordsTyped.TabIndex = 3;
            this.lblWordsTyped.Text = "How many words typed?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 155);
            this.Controls.Add(this.lblWordsTyped);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.btnGrade);
            this.Name = "Form1";
            this.Text = "Lab6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGrade;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblWordsTyped;
    }
}

