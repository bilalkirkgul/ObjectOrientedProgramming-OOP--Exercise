using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_OOPIntro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.FirsName = txtAd.Text;
            student.LastName = txtSoyad.Text;
            student.School = txtUniversite.Text;
            student.BirthDate = dtpDogumTarihi.Value;

            MessageBox.Show(student.ToString());

        }
    }
}
