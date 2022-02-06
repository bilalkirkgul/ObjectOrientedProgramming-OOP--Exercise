using _17_Polymorphism.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_Polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            B b = new B();
            b.X(); // a classdan gelen method
            b.Y(); //classın kendisi içinde yer alan method


            B CObje = new C(); //c objesinden newleme yaptık ama b class referansı kullandık buda polymorphisim kuralıdır. bize sadece referans içierinde olan propları ve methodları getirecektir.
            CObje.X();
            CObje.Y();



        }
    }
}
