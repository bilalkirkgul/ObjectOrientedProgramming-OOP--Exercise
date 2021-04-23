using _09_Interfaces.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_Interfaces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Istavrit ıstavrit = new Istavrit();
            //ıstavrit.Yuz();
            //ıstavrit.Dal();
            //ıstavrit.YuzeyeCik();

            Ucak ucak = new Ucak();
            ucak.Marka = "aaa";
            ucak.Model = "bbb";
            MessageBox.Show($"{ucak.Marka} ");
            ucak.Uc();

            Istavrit ıstavrit = new Istavrit();
            MessageBox.Show(ıstavrit.Yuz());



        }
    }
}
