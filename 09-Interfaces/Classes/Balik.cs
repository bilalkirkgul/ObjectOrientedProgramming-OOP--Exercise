using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces.Classes
{
     abstract class Balik:Hayvan
    {
        //abstrac nesne abstract nesneden kalıtım aldım.

        public decimal SolungacUzunlugu { get; set; }
        public string DenizBolgesi { get; set; }
        public bool PulluMu { get; set; }
    }
}
