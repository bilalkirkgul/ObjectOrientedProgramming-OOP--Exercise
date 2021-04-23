using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces
{
    abstract class Araba
    {
        public int UretimYili { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public decimal Fiyat { get; set; }

        public abstract string MaxHiz();

    }
}
