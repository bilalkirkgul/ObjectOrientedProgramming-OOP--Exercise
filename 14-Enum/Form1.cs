using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] tipler = Enum.GetNames(typeof(UyeTipleri));
            cbTip.Items.AddRange(tipler);
            cbTip.SelectedIndex = 0;
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            Uye uye = new Uye();
            uye.Ad = txtAd.Text;
            uye.Soyad = txtSoyad.Text;
            uye.UyeTipleri= (UyeTipleri)Enum.Parse(typeof(UyeTipleri), cbTip.Text);

            switch (uye.UyeTipleri)
            {
                case UyeTipleri.admin:
                    MessageBox.Show($"{uye.Ad} {uye.Soyad} Admin sayfasına gönderildi");
                    break;
                case UyeTipleri.standart:
                    MessageBox.Show($"{uye.Ad} {uye.Soyad} Standart sayfasına gönderildi");
                    break;
                case UyeTipleri.vip:
                    MessageBox.Show($"{uye.Ad} {uye.Soyad} Vip sayfasına gönderildi");
                    break;
            }

        }
    }
}
