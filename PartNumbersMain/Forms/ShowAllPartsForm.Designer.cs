namespace PartNumbersMain.Forms
{
    partial class ShowAllPartsForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lsShowAll = new System.Windows.Forms.ListBox();
            this.btnaddProduct = new System.Windows.Forms.Button();
            this.btnDeleteProducts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(347, 196);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 30);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lsShowAll
            // 
            this.lsShowAll.FormattingEnabled = true;
            this.lsShowAll.Location = new System.Drawing.Point(34, 40);
            this.lsShowAll.Name = "lsShowAll";
            this.lsShowAll.Size = new System.Drawing.Size(291, 186);
            this.lsShowAll.TabIndex = 2;
            // 
            // btnaddProduct
            // 
            this.btnaddProduct.Location = new System.Drawing.Point(347, 40);
            this.btnaddProduct.Name = "btnaddProduct";
            this.btnaddProduct.Size = new System.Drawing.Size(124, 27);
            this.btnaddProduct.TabIndex = 3;
            this.btnaddProduct.Text = "Add Product";
            this.btnaddProduct.UseVisualStyleBackColor = true;
            this.btnaddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // btnDeleteProducts
            // 
            this.btnDeleteProducts.Location = new System.Drawing.Point(347, 104);
            this.btnDeleteProducts.Name = "btnDeleteProducts";
            this.btnDeleteProducts.Size = new System.Drawing.Size(124, 29);
            this.btnDeleteProducts.TabIndex = 4;
            this.btnDeleteProducts.Text = "Delete Product";
            this.btnDeleteProducts.UseVisualStyleBackColor = true;
            this.btnDeleteProducts.Click += new System.EventHandler(this.BtnDeleteProducts_Click);
            // 
            // ShowAllPartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 269);
            this.Controls.Add(this.btnDeleteProducts);
            this.Controls.Add(this.btnaddProduct);
            this.Controls.Add(this.lsShowAll);
            this.Controls.Add(this.btnExit);
            this.Name = "ShowAllPartsForm";
            this.Text = "ShowAllPartsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lsShowAll;
        private System.Windows.Forms.Button btnaddProduct;
        private System.Windows.Forms.Button btnDeleteProducts;
    }
}