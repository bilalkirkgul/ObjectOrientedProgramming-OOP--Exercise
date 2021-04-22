using _07_Polymorphism.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_Polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTemizlikGorevlisi_Click(object sender, EventArgs e)
        {
            TemizlikGorevlisi temizlikGorevlisi = new TemizlikGorevlisi() { ID = 1, Ad = "aaa", Soyad = "aaa", CalistigiGunSayisi = 30, GunlukKazanc = 100 };
            MessageBox.Show($"{temizlikGorevlisi.Ad} {temizlikGorevlisi.Soyad}\n{temizlikGorevlisi.CalistigiGunSayisi}*{temizlikGorevlisi.GunlukKazanc}\n{temizlikGorevlisi.Maas()} TL");
        }

        private void btnEgitmen_Click(object sender, EventArgs e)
        {
            Egitmen egitmen = new Egitmen();
            egitmen.ID = 2;
            egitmen.Ad = "bbb";
            egitmen.Soyad = "ccc";
            egitmen.CalistigiGunSayisi = 30;
            egitmen.GunlukKazanc = 150;
            egitmen.MemnuniyetAnketSonucu = 2;
            MessageBox.Show($"{egitmen.Ad} {egitmen.Soyad}\n{egitmen.CalistigiGunSayisi}*{egitmen.GunlukKazanc}\n{egitmen.Maas()} TL");

        }

        private void btnBirimMuduru_Click(object sender, EventArgs e)
        {
            BirimMuduru birimMuduru = new BirimMuduru();
            birimMuduru.ID = 3;
            birimMuduru.Ad = "ccc";
            birimMuduru.Soyad = "ccc";
            birimMuduru.CalistigiGunSayisi = 30;
            birimMuduru.GunlukKazanc = 160;
            birimMuduru.Prim = 2500;
            MessageBox.Show($"{birimMuduru.Ad} {birimMuduru.Soyad}\n{birimMuduru.CalistigiGunSayisi}*{birimMuduru.GunlukKazanc}\n{birimMuduru.Maas()} TL");


        }
    }
}
