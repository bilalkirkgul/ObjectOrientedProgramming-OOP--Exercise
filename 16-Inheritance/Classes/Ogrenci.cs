using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Inheritance.Classes
{
    class Ogrenci:Kisi
    {
        public string OkulAdi { get; set; }
        public int OkulNo { get; set; }
        public string Fakulte { get; set; }
        public string Bolum { get; set; }

        public void DersCalis()
        {
            System.Windows.Forms.MessageBox.Show("Ders Çalışıyorum");
        }

    }
}
