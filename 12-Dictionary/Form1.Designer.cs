
namespace _12_Dictionary
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
            this.lbVeri = new System.Windows.Forms.ListBox();
            this.btnDosya = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbVeri
            // 
            this.lbVeri.FormattingEnabled = true;
            this.lbVeri.ItemHeight = 20;
            this.lbVeri.Location = new System.Drawing.Point(467, 35);
            this.lbVeri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbVeri.Name = "lbVeri";
            this.lbVeri.Size = new System.Drawing.Size(300, 304);
            this.lbVeri.TabIndex = 5;
            // 
            // btnDosya
            // 
            this.btnDosya.Location = new System.Drawing.Point(42, 35);
            this.btnDosya.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDosya.Name = "btnDosya";
            this.btnDosya.Size = new System.Drawing.Size(217, 102);
            this.btnDosya.TabIndex = 4;
            this.btnDosya.Text = "Dosyaları Listele";
            this.btnDosya.UseVisualStyleBackColor = true;
            this.btnDosya.Click += new System.EventHandler(this.btnDosya_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbVeri);
            this.Controls.Add(this.btnDosya);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbVeri;
        private System.Windows.Forms.Button btnDosya;
    }
}

