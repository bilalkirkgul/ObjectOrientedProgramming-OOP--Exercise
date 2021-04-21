using _05_Encapsulation.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_Encapsulation
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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.SetOkulNo(int.Parse(txtOkulNo.Text));
                ogrenci.SetIsim(txtAdSoyad.Text);
                ogrenci.SetDogumTarihi(dtpDogumTarihi.Value);

                MessageBox.Show(ogrenci.GetOkulNo().ToString() + " " + ogrenci.GetIsim() + " " + ogrenci.GetDogumTarihi());

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
