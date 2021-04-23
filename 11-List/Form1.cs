using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_List
{
    public partial class Form1 : Form
    {

        List<string> adlar;
        public Form1()
        {
            adlar = new List<string>();
            InitializeComponent();
        }

        private void btnUrun_Click(object sender, EventArgs e)
        {
            lbVeri.Items.Clear();//lb içerisinde yer alan veriler silinecek..
            List<string> urunler = new List<string>() { "mause", "monitör", "klavye", "mausepad", "usp", "ups", "notebook" };

            foreach (string item in urunler) //List içerisindeki urunler foreach ile dönüldü ve tek tek bütün elamanlar lbVeri içerisine basıldı
            {
                lbVeri.Items.Add(item);
            }


        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text; //text içerisine girilen değerleri ad adındaki string değişkene aktarıldı
            adlar.Add(ad);// List tipinde oluşturmuş olduğumuz adlar'a text içeriisnde girilen değerler butana her tıklandığında eklendi..

            txtAd.Text =string.Empty;//text içerisine girilen değerler buton tıklandıktan sonra temizlendi.
            
        }

        private void btnIsim_Click(object sender, EventArgs e)
        {
            lbVeri.Items.Clear();

            foreach (string item in adlar)
            {
                lbVeri.Items.Add(item);
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            lbVeri.Items.Clear();
            List<Product> products = new List<Product>()
            {
                new Product{ID=5, ProductName="Elma",Price=5 },
                new Product{ID=2,ProductName="Kiraz",Price=6},
                new Product{ID=3,ProductName="Karpuz",Price=10},new Product{ ID=4,ProductName="Portakal",Price=9}
            };

            products.Add(new Product { ID = 1, ProductName = "Kitap", Price = 25 });

            foreach (Product item in products)
            {
                lbVeri.Items.Add(item); //ToString methodunu overrite ettiğimiz için add içerisine product özelliklerini tek tek vermemize gerek kalmadı..
            }

        }

        private void btnMetotlar_Click(object sender, EventArgs e)
        {
            lbVeri.Items.Clear();
            List<string> urunler = new List<string>() { "mause", "monitör", "klavye", "mausepad", "usp", "ups", "notebook" };



            if (urunler.Contains("klavye"))
            {
                MessageBox.Show("ürün listede mevcuttur");
            }
            else
            {
                MessageBox.Show("Böyle bir ürün yoktur");
            }


        }
    }
}
