
namespace _07_Polymorphism
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
            this.btnTemizlikGorevlisi = new System.Windows.Forms.Button();
            this.btnBirimMuduru = new System.Windows.Forms.Button();
            this.btnEgitmen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTemizlikGorevlisi
            // 
            this.btnTemizlikGorevlisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizlikGorevlisi.Location = new System.Drawing.Point(60, 73);
            this.btnTemizlikGorevlisi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTemizlikGorevlisi.Name = "btnTemizlikGorevlisi";
            this.btnTemizlikGorevlisi.Size = new System.Drawing.Size(307, 116);
            this.btnTemizlikGorevlisi.TabIndex = 10;
            this.btnTemizlikGorevlisi.Text = "Temizlik Görevlisi";
            this.btnTemizlikGorevlisi.UseVisualStyleBackColor = true;
            this.btnTemizlikGorevlisi.Click += new System.EventHandler(this.btnTemizlikGorevlisi_Click);
            // 
            // btnBirimMuduru
            // 
            this.btnBirimMuduru.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBirimMuduru.Location = new System.Drawing.Point(60, 425);
            this.btnBirimMuduru.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBirimMuduru.Name = "btnBirimMuduru";
            this.btnBirimMuduru.Size = new System.Drawing.Size(307, 116);
            this.btnBirimMuduru.TabIndex = 9;
            this.btnBirimMuduru.Text = "Birim Müdürü";
            this.btnBirimMuduru.UseVisualStyleBackColor = true;
            this.btnBirimMuduru.Click += new System.EventHandler(this.btnBirimMuduru_Click);
            // 
            // btnEgitmen
            // 
            this.btnEgitmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEgitmen.Location = new System.Drawing.Point(60, 238);
            this.btnEgitmen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEgitmen.Name = "btnEgitmen";
            this.btnEgitmen.Size = new System.Drawing.Size(307, 116);
            this.btnEgitmen.TabIndex = 8;
            this.btnEgitmen.Text = "Egitmen";
            this.btnEgitmen.UseVisualStyleBackColor = true;
            this.btnEgitmen.Click += new System.EventHandler(this.btnEgitmen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 586);
            this.Controls.Add(this.btnTemizlikGorevlisi);
            this.Controls.Add(this.btnBirimMuduru);
            this.Controls.Add(this.btnEgitmen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTemizlikGorevlisi;
        private System.Windows.Forms.Button btnBirimMuduru;
        private System.Windows.Forms.Button btnEgitmen;
    }
}

