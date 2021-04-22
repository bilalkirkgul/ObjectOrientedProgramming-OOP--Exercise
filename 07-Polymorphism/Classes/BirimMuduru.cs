using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Polymorphism.Classes
{
    class BirimMuduru:Personel
    {

        public decimal Prim { get; set; }
        public override decimal Maas()
        {
            return CalistigiGunSayisi * GunlukKazanc * 2 + Prim;
        }



    }
}
