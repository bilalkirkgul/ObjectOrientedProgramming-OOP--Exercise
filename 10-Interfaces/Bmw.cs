using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces
{
    class Bmw : Araba, IYetenek
    {
        public override string MaxHiz()
        {
            return "300 km hız yapıyor ";
        }

        public string OtoPilot()
        {
            return "Otomatik Pilot desteği yok";
        }
    }
}
