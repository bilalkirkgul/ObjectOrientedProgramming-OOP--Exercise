using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblGunler.Text = EnumClassi.pazar.ToString();
            lblDays.Text = DayOfWeek.Friday.ToString();

            int index = (int)EnumClassi.pazartesi; //cast rica işlemi
            MessageBox.Show(index.ToString()); //pazartesinin index numarasını basma işlemi

            MessageBox.Show(KullaniciTipleri.vip.ToString());
            MessageBox.Show(((KullaniciTipleri)'a').ToString());


        }
    }
}
