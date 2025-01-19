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
    public partial class MyFourthCustmControl : UserControl
    {
        public MyFourthCustmControl()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a1 = float.Parse(A.Text);
            float b1 = float.Parse(B.Text);
            double suma = a1 * b1;
            P.Text = suma.ToString();
            side1.Text = A.Text;
            side2.Text = B.Text;
            pole.Text = P.Text;
        }
    }
}
