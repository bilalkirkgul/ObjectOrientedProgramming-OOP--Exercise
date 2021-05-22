using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Inheritance.Classes
{
    class Personel: Kisi//Bir class sadece bir classtan kalıtım miras alabilir...
    {
        public DateTime IseGirisTarihi { get; set; }
        public string CalistigiSirketAdi { get; set; }
        public string SicilNo { get; set; }

    }
}
