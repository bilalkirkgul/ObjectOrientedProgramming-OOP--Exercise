using _16_Inheritance.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Egitmen egitmen = new Egitmen();
            egitmen.ID = 1; //Kisi
            egitmen.FirstName = "Bilal"; //Kisi
            egitmen.LastName = "Kırkgül"; //Kisi
            egitmen.Cinsiyet = "Erkek"; //Kisi
            egitmen.CalistigiSirketAdi = "bllsoft";
            egitmen.IseGirisTarihi = DateTime.Now;
            egitmen.SicilNo = "001";

            MessageBox.Show($"{egitmen.FirstName} {egitmen.LastName}");
            egitmen.DersAnlat();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.FirstName = "yusuf";
            ogrenci.LastName = "Ay";
            ogrenci.OkulAdi = "Marmamara";
            ogrenci.Cinsiyet = "Erkek";

            MessageBox.Show($"{ogrenci.FirstName} {ogrenci.LastName} {ogrenci.OkulAdi}");
            ogrenci.DersCalis();
        }
    }
}
