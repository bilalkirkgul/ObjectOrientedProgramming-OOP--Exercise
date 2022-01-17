using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Abstraction.Classes
{
    class KursunKalem : Kalem
    {
        public override void Boya()
        {
            System.Windows.Forms.MessageBox.Show("Boyama işlemi yapıldı");
        }

        public override string Ciz()
        {
            return "Kursun kalemle çizildi";
        }
    }
}
