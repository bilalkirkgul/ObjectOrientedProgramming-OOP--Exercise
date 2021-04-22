using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Polymorphism.Classes
{
    class Egitmen:Personel
    {
        public decimal MemnuniyetAnketSonucu { get; set; }

        public override decimal Maas()
        {
            return CalistigiGunSayisi * GunlukKazanc * (1 + MemnuniyetAnketSonucu);
        }
    }
}
