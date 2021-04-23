
namespace _11_List
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
            this.btnMetotlar = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnIsim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnUrun = new System.Windows.Forms.Button();
            this.lbVeri = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnMetotlar
            // 
            this.btnMetotlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMetotlar.Location = new System.Drawing.Point(192, 366);
            this.btnMetotlar.Name = "btnMetotlar";
            this.btnMetotlar.Size = new System.Drawing.Size(205, 38);
            this.btnMetotlar.TabIndex = 23;
            this.btnMetotlar.Text = "Metot Kullanımı";
            this.btnMetotlar.UseVisualStyleBackColor = true;
            this.btnMetotlar.Click += new System.EventHandler(this.btnMetotlar_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProduct.Location = new System.Drawing.Point(192, 294);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(205, 38);
            this.btnProduct.TabIndex = 22;
            this.btnProduct.Text = "Product Listele";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnIsim
            // 
            this.btnIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIsim.Location = new System.Drawing.Point(194, 223);
            this.btnIsim.Name = "btnIsim";
            this.btnIsim.Size = new System.Drawing.Size(205, 38);
            this.btnIsim.TabIndex = 21;
            this.btnIsim.Text = "İsim Listele";
            this.btnIsim.UseVisualStyleBackColor = true;
            this.btnIsim.Click += new System.EventHandler(this.btnIsim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(81, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 44);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ad";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(194, 159);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(205, 38);
            this.btnEkle.TabIndex = 19;
            this.btnEkle.Text = "İsim Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(163, 98);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(234, 35);
            this.txtAd.TabIndex = 18;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // btnUrun
            // 
            this.btnUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrun.Location = new System.Drawing.Point(194, 29);
            this.btnUrun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUrun.Name = "btnUrun";
            this.btnUrun.Size = new System.Drawing.Size(203, 37);
            this.btnUrun.TabIndex = 17;
            this.btnUrun.Text = "Ürünleri Listele";
            this.btnUrun.UseVisualStyleBackColor = true;
            this.btnUrun.Click += new System.EventHandler(this.btnUrun_Click);
            // 
            // lbVeri
            // 
            this.lbVeri.FormattingEnabled = true;
            this.lbVeri.ItemHeight = 20;
            this.lbVeri.Location = new System.Drawing.Point(429, 14);
            this.lbVeri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbVeri.Name = "lbVeri";
            this.lbVeri.Size = new System.Drawing.Size(447, 404);
            this.lbVeri.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 490);
            this.Controls.Add(this.btnMetotlar);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnIsim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.btnUrun);
            this.Controls.Add(this.lbVeri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMetotlar;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnIsim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnUrun;
        private System.Windows.Forms.ListBox lbVeri;
    }
}

