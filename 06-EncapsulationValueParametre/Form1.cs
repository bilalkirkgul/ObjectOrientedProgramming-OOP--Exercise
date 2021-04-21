using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_EncapsulationValueParametre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            try
            {

                Personel personel = new Personel();
                personel.Ad = txtAd.Text;
                personel.Soyad = txtSoyad.Text;
                personel.TCKimlikNo = txtTCKN.Text;
                personel.PersonelNo = txtPersonelNo.Text;
                personel.Mail = txtMail.Text;

                if (rbBekar.Checked)
                {
                    personel.MedeniHal = "Bekar";
                }
                else
                {
                    personel.MedeniHal = "Evli";
                }
                MessageBox.Show($"{personel.Ad} {personel.Soyad} {personel.TCKimlikNo} {personel.PersonelNo} {personel.Mail} {personel.MedeniHal}");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
