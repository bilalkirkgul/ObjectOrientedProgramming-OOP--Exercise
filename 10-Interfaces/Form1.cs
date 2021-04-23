using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Interfaces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Tesla tesla = new Tesla();
            //tesla.Renk = "Siyah";
            //MessageBox.Show(tesla.Renk);
            //MessageBox.Show(tesla.OtoPilot());
            //MessageBox.Show(tesla.MaxHiz());


            Audi audi = new Audi();
            audi.Fiyat = 300.00m;
            audi.Model = "a6";
            MessageBox.Show(audi.Fiyat.ToString());
            MessageBox.Show(audi.Model);
            MessageBox.Show(audi.MaxHiz());
            MessageBox.Show(audi.OtoPilot());
        }
    }
}
