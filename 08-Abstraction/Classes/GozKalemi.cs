using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Abstraction.Classes
{
    class GozKalemi : Kalem
    {
        public override void Boya()
        {
            System.Windows.Forms.MessageBox.Show("Goz kalemi ile boyama işlemi yapıldı");
        }

        public override string Ciz()
        {
            return "Göz kalemi ile çizildi";
        }
    }
}
