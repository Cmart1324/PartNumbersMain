namespace PartNumbersMain
{
    partial class AddPartsForm
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
            this.btnClear = new System.Windows.Forms.Button();
            this.textBoxPartDesc = new System.Windows.Forms.TextBox();
            this.textBoxPartPrice = new System.Windows.Forms.TextBox();
            this.textBoxPartNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnClear.Location = new System.Drawing.Point(199, 140);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // textBoxPartDesc
            // 
            this.textBoxPartDesc.Location = new System.Drawing.Point(174, 104);
            this.textBoxPartDesc.Name = "textBoxPartDesc";
            this.textBoxPartDesc.Size = new System.Drawing.Size(100, 20);
            this.textBoxPartDesc.TabIndex = 8;
            // 
            // textBoxPartPrice
            // 
            this.textBoxPartPrice.Location = new System.Drawing.Point(174, 75);
            this.textBoxPartPrice.Name = "textBoxPartPrice";
            this.textBoxPartPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPartPrice.TabIndex = 7;
            // 
            // textBoxPartNumber
            // 
            this.textBoxPartNumber.Location = new System.Drawing.Point(174, 37);
            this.textBoxPartNumber.MaxLength = 9;
            this.textBoxPartNumber.Name = "textBoxPartNumber";
            this.textBoxPartNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxPartNumber.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Part description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Part Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Part Number";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(54, 140);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // AddPartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 194);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.textBoxPartDesc);
            this.Controls.Add(this.textBoxPartPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPartNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddPartsForm";
            this.Text = "Add Parts Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox textBoxPartDesc;
        private System.Windows.Forms.TextBox textBoxPartPrice;
        private System.Windows.Forms.TextBox textBoxPartNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
    }
}