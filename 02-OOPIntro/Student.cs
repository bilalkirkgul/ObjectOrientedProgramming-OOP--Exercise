using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOPIntro
{
    class Student
    {
        public int ID { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string School { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return $"{FirsName}\n{LastName}\n{School}\n{BirthDate}";
        }
    }
}
