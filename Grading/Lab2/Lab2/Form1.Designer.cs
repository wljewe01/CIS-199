namespace Lab2
{
    partial class Lab2
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
            this.priceLabel = new System.Windows.Forms.Label();
            this.lowtiplabel = new System.Windows.Forms.Label();
            this.medtiplabel = new System.Windows.Forms.Label();
            this.hightiplabel = new System.Windows.Forms.Label();
            this.MealTextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.LowTipL = new System.Windows.Forms.Label();
            this.MediumTipL = new System.Windows.Forms.Label();
            this.HighTipL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(37, 31);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(98, 13);
            this.priceLabel.TabIndex = 0;
            this.priceLabel.Text = "Enter price of meal:";
            // 
            // lowtiplabel
            // 
            this.lowtiplabel.AutoSize = true;
            this.lowtiplabel.Location = new System.Drawing.Point(102, 75);
            this.lowtiplabel.Name = "lowtiplabel";
            this.lowtiplabel.Size = new System.Drawing.Size(30, 13);
            this.lowtiplabel.TabIndex = 1;
            this.lowtiplabel.Text = "15 %";
            // 
            // medtiplabel
            // 
            this.medtiplabel.AutoSize = true;
            this.medtiplabel.Location = new System.Drawing.Point(102, 125);
            this.medtiplabel.Name = "medtiplabel";
            this.medtiplabel.Size = new System.Drawing.Size(30, 13);
            this.medtiplabel.TabIndex = 2;
            this.medtiplabel.Text = "18 %";
            // 
            // hightiplabel
            // 
            this.hightiplabel.AutoSize = true;
            this.hightiplabel.Location = new System.Drawing.Point(102, 174);
            this.hightiplabel.Name = "hightiplabel";
            this.hightiplabel.Size = new System.Drawing.Size(30, 13);
            this.hightiplabel.TabIndex = 3;
            this.hightiplabel.Text = "20 %";
            // 
            // MealTextBox
            // 
            this.MealTextBox.Location = new System.Drawing.Point(156, 24);
            this.MealTextBox.Name = "MealTextBox";
            this.MealTextBox.Size = new System.Drawing.Size(100, 20);
            this.MealTextBox.TabIndex = 4;
            this.MealTextBox.TextChanged += new System.EventHandler(this.MealTextBox_TextChanged);
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CalculateButton.Location = new System.Drawing.Point(105, 238);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(92, 23);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "Calculate Tip";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // LowTipL
            // 
            this.LowTipL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LowTipL.Location = new System.Drawing.Point(153, 75);
            this.LowTipL.Name = "LowTipL";
            this.LowTipL.Size = new System.Drawing.Size(100, 23);
            this.LowTipL.TabIndex = 9;
            // 
            // MediumTipL
            // 
            this.MediumTipL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MediumTipL.Location = new System.Drawing.Point(153, 124);
            this.MediumTipL.Name = "MediumTipL";
            this.MediumTipL.Size = new System.Drawing.Size(100, 23);
            this.MediumTipL.TabIndex = 10;
            this.MediumTipL.Click += new System.EventHandler(this.label2_Click);
            // 
            // HighTipL
            // 
            this.HighTipL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HighTipL.Location = new System.Drawing.Point(153, 173);
            this.HighTipL.Name = "HighTipL";
            this.HighTipL.Size = new System.Drawing.Size(100, 23);
            this.HighTipL.TabIndex = 11;
            // 
            // Lab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.HighTipL);
            this.Controls.Add(this.MediumTipL);
            this.Controls.Add(this.LowTipL);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.MealTextBox);
            this.Controls.Add(this.hightiplabel);
            this.Controls.Add(this.medtiplabel);
            this.Controls.Add(this.lowtiplabel);
            this.Controls.Add(this.priceLabel);
            this.Name = "Lab2";
            this.Text = "Lab2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label lowtiplabel;
        private System.Windows.Forms.Label medtiplabel;
        private System.Windows.Forms.Label hightiplabel;
        private System.Windows.Forms.TextBox MealTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label LowTipL;
        private System.Windows.Forms.Label MediumTipL;
        private System.Windows.Forms.Label HighTipL;
    }
}

