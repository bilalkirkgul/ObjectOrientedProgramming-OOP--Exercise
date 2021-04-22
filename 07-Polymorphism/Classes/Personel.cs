using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Polymorphism.Classes
{
    class Personel
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int CalistigiGunSayisi { get; set; }
        public decimal GunlukKazanc { get; set; }

        public virtual decimal Maas()
        {
            return CalistigiGunSayisi * GunlukKazanc;
        }
    }
}
