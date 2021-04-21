using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_OOPIntro
{
    class Student
    {
        public int ID { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public int Yas { get; set; }
        public override string ToString()
        {
            return $"{FirsName}\n{LastName}\n{Yas}";
        }
    }
}
