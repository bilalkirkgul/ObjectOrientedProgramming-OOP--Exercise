using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces.Classes
{
   abstract class Kus:Hayvan
    {
        //Hayvanın nesnesinin özelliklerini taşıyor, Abstract nesneden kalıtım aldım

        public decimal KanatUzunlugu { get; set; }


    }
}
