using _08_Abstraction.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_Abstraction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GozKalemi gozKalemi = new GozKalemi();
            MessageBox.Show(gozKalemi.Ciz());

            KursunKalem kursunKalem = new KursunKalem();
            kursunKalem.Marka = "FaberCastell";
            kursunKalem.Renk = "Siyah";
            kursunKalem.Boya();
            MessageBox.Show($"{kursunKalem.Marka} {kursunKalem.Renk} {kursunKalem.Ciz()}");
        }
    }
}
