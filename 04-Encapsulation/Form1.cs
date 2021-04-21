using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Elma elma = new Elma();
            elma.SetAgirlik(3);
            elma.SetFiyat(2);
            MessageBox.Show(elma.GetAgirlik().ToString());
            MessageBox.Show(elma.GetFiyat().ToString());
        }
    }
}
