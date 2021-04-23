using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_Dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDosya_Click(object sender, EventArgs e)
        {
            //Dictionary<int, string> sehirler = new Dictionary<int, string>();

            //sehirler.Add(6, "Ankara");
            //sehirler.Add(34, "İstanbul");
            //sehirler.Add(1, "Adana");

            //foreach (KeyValuePair<int,string> item in sehirler)
            //{
            //    lbVeri.Items.Add(item.Key+" "+item.Value);
            //}


            Dictionary<string, string> veri = new Dictionary<string, string>();
            veri.Add("txt", "Not Defteri");
            veri.Add("docx", "Dokuman");
            veri.Add("sln", "Solution");
            veri.Add("cs", "Class");

            ICollection<string> anahtarlar = veri.Keys;

            foreach (var key in anahtarlar)
            {
                lbVeri.Items.Add(key + " " + veri[key]);
            }

        }
    }
}
