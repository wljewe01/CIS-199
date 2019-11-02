namespace Lab2
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
            this.mealPriceLbl = new System.Windows.Forms.Label();
            this.tip1Lbl = new System.Windows.Forms.Label();
            this.tip2Lbl = new System.Windows.Forms.Label();
            this.tip3Lbl = new System.Windows.Forms.Label();
            this.priceTxtBox = new System.Windows.Forms.TextBox();
            this.tip1OutputLbl = new System.Windows.Forms.Label();
            this.tip2OutputLbl = new System.Windows.Forms.Label();
            this.tip3OutputLbl = new System.Windows.Forms.Label();
            this.calculateBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mealPriceLbl
            // 
            this.mealPriceLbl.AutoSize = true;
            this.mealPriceLbl.Location = new System.Drawing.Point(44, 9);
            this.mealPriceLbl.Name = "mealPriceLbl";
            this.mealPriceLbl.Size = new System.Drawing.Size(98, 13);
            this.mealPriceLbl.TabIndex = 0;
            this.mealPriceLbl.Text = "Enter price of meal:";
            this.mealPriceLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // tip1Lbl
            // 
            this.tip1Lbl.AutoSize = true;
            this.tip1Lbl.Location = new System.Drawing.Point(115, 45);
            this.tip1Lbl.Name = "tip1Lbl";
            this.tip1Lbl.Size = new System.Drawing.Size(30, 13);
            this.tip1Lbl.TabIndex = 1;
            this.tip1Lbl.Text = "15 %";
            // 
            // tip2Lbl
            // 
            this.tip2Lbl.AutoSize = true;
            this.tip2Lbl.Location = new System.Drawing.Point(115, 81);
            this.tip2Lbl.Name = "tip2Lbl";
            this.tip2Lbl.Size = new System.Drawing.Size(30, 13);
            this.tip2Lbl.TabIndex = 2;
            this.tip2Lbl.Text = "18 %";
            this.tip2Lbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // tip3Lbl
            // 
            this.tip3Lbl.AutoSize = true;
            this.tip3Lbl.Location = new System.Drawing.Point(115, 117);
            this.tip3Lbl.Name = "tip3Lbl";
            this.tip3Lbl.Size = new System.Drawing.Size(30, 13);
            this.tip3Lbl.TabIndex = 3;
            this.tip3Lbl.Text = "20 %";
            // 
            // priceTxtBox
            // 
            this.priceTxtBox.Location = new System.Drawing.Point(157, 12);
            this.priceTxtBox.Name = "priceTxtBox";
            this.priceTxtBox.Size = new System.Drawing.Size(100, 20);
            this.priceTxtBox.TabIndex = 4;
            // 
            // tip1OutputLbl
            // 
            this.tip1OutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tip1OutputLbl.Location = new System.Drawing.Point(154, 44);
            this.tip1OutputLbl.Name = "tip1OutputLbl";
            this.tip1OutputLbl.Size = new System.Drawing.Size(103, 22);
            this.tip1OutputLbl.TabIndex = 5;
            // 
            // tip2OutputLbl
            // 
            this.tip2OutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tip2OutputLbl.Location = new System.Drawing.Point(154, 80);
            this.tip2OutputLbl.Name = "tip2OutputLbl";
            this.tip2OutputLbl.Size = new System.Drawing.Size(103, 25);
            this.tip2OutputLbl.TabIndex = 6;
            this.tip2OutputLbl.Click += new System.EventHandler(this.tip2OutputLbl_Click);
            // 
            // tip3OutputLbl
            // 
            this.tip3OutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tip3OutputLbl.Location = new System.Drawing.Point(154, 116);
            this.tip3OutputLbl.Name = "tip3OutputLbl";
            this.tip3OutputLbl.Size = new System.Drawing.Size(103, 23);
            this.tip3OutputLbl.TabIndex = 7;
            // 
            // calculateBttn
            // 
            this.calculateBttn.BackColor = System.Drawing.SystemColors.Control;
            this.calculateBttn.Location = new System.Drawing.Point(118, 156);
            this.calculateBttn.Name = "calculateBttn";
            this.calculateBttn.Size = new System.Drawing.Size(86, 23);
            this.calculateBttn.TabIndex = 8;
            this.calculateBttn.Text = "Calculate Tip";
            this.calculateBttn.UseVisualStyleBackColor = false;
            this.calculateBttn.Click += new System.EventHandler(this.calculateBttn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 191);
            this.Controls.Add(this.calculateBttn);
            this.Controls.Add(this.tip3OutputLbl);
            this.Controls.Add(this.tip2OutputLbl);
            this.Controls.Add(this.tip1OutputLbl);
            this.Controls.Add(this.priceTxtBox);
            this.Controls.Add(this.tip3Lbl);
            this.Controls.Add(this.tip2Lbl);
            this.Controls.Add(this.tip1Lbl);
            this.Controls.Add(this.mealPriceLbl);
            this.Name = "Form1";
            this.Text = "Lab2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mealPriceLbl;
        private System.Windows.Forms.Label tip1Lbl;
        private System.Windows.Forms.Label tip2Lbl;
        private System.Windows.Forms.Label tip3Lbl;
        private System.Windows.Forms.TextBox priceTxtBox;
        private System.Windows.Forms.Label tip1OutputLbl;
        private System.Windows.Forms.Label tip2OutputLbl;
        private System.Windows.Forms.Label tip3OutputLbl;
        private System.Windows.Forms.Button calculateBttn;
    }
}

