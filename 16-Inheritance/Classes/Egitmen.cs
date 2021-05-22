using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Inheritance.Classes
{
    class Egitmen:Personel //Bir class sadece bir classtan kalıtım miras alabilir...
    {
       public void DersAnlat()
        {
            System.Windows.Forms.MessageBox.Show("Ders Anlatıyorum");
        }

    }
}
