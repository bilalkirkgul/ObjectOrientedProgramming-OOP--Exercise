using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces
{
    class Tesla : Araba,IYetenek
    {
        public override string MaxHiz()
        {
            return "350 km hız yapıyor";
        }

        public string OtoPilot()
        {
            return "Oto pilot mevcuttur";
        }
    }
}
