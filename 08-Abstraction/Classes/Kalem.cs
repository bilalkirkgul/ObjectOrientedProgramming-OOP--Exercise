using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Abstraction.Classes
{
    abstract class Kalem
    {
        //Clasın üyesi abstractsa class abstract olmak zorundadır.
        //Base Class mantığıyla çalışırlar..
        //Newlenemezler..
        //Class abstract diye classın tüm üyeleri abstract olmak zorunda değildir.
        //Abstract methodların gövdesi olmaz, kalıtım verildiği yerde implament edilip kullanılması zorunludur.

        public string Renk { get; set; }
        public string Marka { get; set; }
        public abstract string Ciz();
      

    }
}
