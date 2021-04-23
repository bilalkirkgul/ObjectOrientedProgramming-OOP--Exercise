using _09_Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces.Classes
{
    class Serce : Kus, IUcabilir
    {
        //Kustan Kalıtım alıyor, dolayısıyla hayvan nesnesinin özelliklerinide taşıyor
        public void Uc()
        {
            System.Windows.Forms.MessageBox.Show("Serce Uçuyor");
        }
    }
}
