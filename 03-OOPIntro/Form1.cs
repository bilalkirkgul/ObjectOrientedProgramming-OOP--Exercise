using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_OOPIntro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Student[] students = new Student[0];
        List<Student> students = new List<Student>();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Student student = new Student() { FirsName = txtAd.Text, LastName = txtSoyad.Text, Yas = int.Parse(txtYas.Text) };

            //student.FirsName = txtAd.Text;
            //student.LastName = txtSoyad.Text;
            //student.Yas = int.Parse(txtYas.Text);

            //Array.Resize(ref students, students.Length + 1);
            //students[students.Length - 1] = student;

            students.Add(student);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            foreach (Student item in students)
            {
                lbOgrenciler.Items.Add(item.ToString());
            }
        }
    }
}
