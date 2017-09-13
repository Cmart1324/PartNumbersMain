namespace PartNumbersMain.Forms
{
    partial class MainForm
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
            this.btnAddParts = new System.Windows.Forms.Button();
            this.btnShowParts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddParts
            // 
            this.btnAddParts.Location = new System.Drawing.Point(75, 129);
            this.btnAddParts.Name = "btnAddParts";
            this.btnAddParts.Size = new System.Drawing.Size(112, 58);
            this.btnAddParts.TabIndex = 0;
            this.btnAddParts.Text = "Add Parts";
            this.btnAddParts.UseVisualStyleBackColor = true;
            this.btnAddParts.Click += new System.EventHandler(this.BtnAddParts_Click);
            // 
            // btnShowParts
            // 
            this.btnShowParts.Location = new System.Drawing.Point(272, 129);
            this.btnShowParts.Name = "btnShowParts";
            this.btnShowParts.Size = new System.Drawing.Size(111, 58);
            this.btnShowParts.TabIndex = 1;
            this.btnShowParts.Text = "Show Parts";
            this.btnShowParts.UseVisualStyleBackColor = true;
            this.btnShowParts.Click += new System.EventHandler(this.btnShowParts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome!!!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 291);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowParts);
            this.Controls.Add(this.btnAddParts);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddParts;
        private System.Windows.Forms.Button btnShowParts;
        private System.Windows.Forms.Label label1;
    }
}

