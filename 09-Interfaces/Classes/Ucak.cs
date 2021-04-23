using _09_Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces.Classes
{
    class Ucak : Tasit, IUcabilir
    {
        public void Uc()
        {
            System.Windows.Forms.MessageBox.Show("Uçak uçuyor");
        }
    }
}
