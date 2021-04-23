using _09_Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces.Classes
{
    class Istavrit : Balik,IDalCik,IYuzebilir
    {
        public void Dal()
        {
            System.Windows.Forms.MessageBox.Show("İstavrit dal");
        }

        public string Yuz()
        {
            return "yuzeye çık";
        }

        public void YuzeyeCik()
        {
            System.Windows.Forms.MessageBox.Show("İstavrit yüzeye çık");
        }

        
    }
}
