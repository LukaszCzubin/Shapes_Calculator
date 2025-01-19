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
    public partial class trapez : UserControl
    {
        public trapez()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a1 = float.Parse(A.Text);
            float b1 = float.Parse(B.Text);
            float h1 = float.Parse(H.Text);
            float suma = ((a1 + b1) / 2) * 2;
            P.Text = suma.ToString();
            side1.Text = A.Text;
            side2.Text = B.Text;
            wysokosc.Text = H.Text;
            pole.Text = P.Text;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void trapez_Load(object sender, EventArgs e)
        {

        }
    }
}
