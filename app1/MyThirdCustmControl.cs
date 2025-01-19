using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app1
{
    public partial class MyThirdCustmControl : UserControl
    {
        public MyThirdCustmControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a1 = float.Parse(A.Text);
            double pi = 3.14;
            double suma = pi * (a1 * a1);
            P.Text = suma.ToString();
            side1.Text = A.Text;
            pole.Text = P.Text;
        }
    }
}
