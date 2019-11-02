namespace Exam2Part3
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
            this.idLbl = new System.Windows.Forms.Label();
            this.purchasePriceLbl = new System.Windows.Forms.Label();
            this.discountLbl = new System.Windows.Forms.Label();
            this.salePriceLbl = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.purchasePriceTxt = new System.Windows.Forms.TextBox();
            this.calcSalePriceBtn = new System.Windows.Forms.Button();
            this.discountOutputLbl = new System.Windows.Forms.Label();
            this.salePriceOutputLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idLbl
            // 
            this.idLbl.Location = new System.Drawing.Point(29, 13);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(68, 13);
            this.idLbl.TabIndex = 0;
            this.idLbl.Text = "Customer ID:";
            this.idLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // purchasePriceLbl
            // 
            this.purchasePriceLbl.Location = new System.Drawing.Point(13, 36);
            this.purchasePriceLbl.Name = "purchasePriceLbl";
            this.purchasePriceLbl.Size = new System.Drawing.Size(84, 13);
            this.purchasePriceLbl.TabIndex = 1;
            this.purchasePriceLbl.Text = "Purchase Price:";
            this.purchasePriceLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // discountLbl
            // 
            this.discountLbl.Location = new System.Drawing.Point(29, 59);
            this.discountLbl.Name = "discountLbl";
            this.discountLbl.Size = new System.Drawing.Size(68, 13);
            this.discountLbl.TabIndex = 2;
            this.discountLbl.Text = "Discount %:";
            this.discountLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // salePriceLbl
            // 
            this.salePriceLbl.Location = new System.Drawing.Point(29, 82);
            this.salePriceLbl.Name = "salePriceLbl";
            this.salePriceLbl.Size = new System.Drawing.Size(68, 13);
            this.salePriceLbl.TabIndex = 3;
            this.salePriceLbl.Text = "Sale Price:";
            this.salePriceLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(103, 10);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(100, 20);
            this.idTxt.TabIndex = 4;
            // 
            // purchasePriceTxt
            // 
            this.purchasePriceTxt.Location = new System.Drawing.Point(103, 33);
            this.purchasePriceTxt.Name = "purchasePriceTxt";
            this.purchasePriceTxt.Size = new System.Drawing.Size(100, 20);
            this.purchasePriceTxt.TabIndex = 5;
            // 
            // calcSalePriceBtn
            // 
            this.calcSalePriceBtn.Location = new System.Drawing.Point(48, 105);
            this.calcSalePriceBtn.Name = "calcSalePriceBtn";
            this.calcSalePriceBtn.Size = new System.Drawing.Size(127, 23);
            this.calcSalePriceBtn.TabIndex = 8;
            this.calcSalePriceBtn.Text = "Calculate Sale Price";
            this.calcSalePriceBtn.UseVisualStyleBackColor = true;
            this.calcSalePriceBtn.Click += new System.EventHandler(this.calcSalePriceBtn_Click);
            // 
            // discountOutputLbl
            // 
            this.discountOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discountOutputLbl.Location = new System.Drawing.Point(103, 58);
            this.discountOutputLbl.Name = "discountOutputLbl";
            this.discountOutputLbl.Size = new System.Drawing.Size(100, 20);
            this.discountOutputLbl.TabIndex = 9;
            this.discountOutputLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // salePriceOutputLbl
            // 
            this.salePriceOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salePriceOutputLbl.Location = new System.Drawing.Point(103, 81);
            this.salePriceOutputLbl.Name = "salePriceOutputLbl";
            this.salePriceOutputLbl.Size = new System.Drawing.Size(100, 20);
            this.salePriceOutputLbl.TabIndex = 10;
            this.salePriceOutputLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AcceptButton = this.calcSalePriceBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 141);
            this.Controls.Add(this.salePriceOutputLbl);
            this.Controls.Add(this.discountOutputLbl);
            this.Controls.Add(this.calcSalePriceBtn);
            this.Controls.Add(this.purchasePriceTxt);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.salePriceLbl);
            this.Controls.Add(this.discountLbl);
            this.Controls.Add(this.purchasePriceLbl);
            this.Controls.Add(this.idLbl);
            this.Name = "Form1";
            this.Text = "Exam 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label purchasePriceLbl;
        private System.Windows.Forms.Label discountLbl;
        private System.Windows.Forms.Label salePriceLbl;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.TextBox purchasePriceTxt;
        private System.Windows.Forms.Button calcSalePriceBtn;
        private System.Windows.Forms.Label discountOutputLbl;
        private System.Windows.Forms.Label salePriceOutputLbl;
    }
}

