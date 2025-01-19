using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app1
{
    public partial class FirstUserControl : UserControl
    {
        public FirstUserControl()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a1 = float.Parse(A.Text);
            float b1 = float.Parse(B.Text);
            float suma = (a1 * b1) / 2;
            P.Text = suma.ToString();
            side1.Text = A.Text;
            side2.Text = B.Text;
            pole.Text = P.Text;
        }

        private void FirstUserControl_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void A_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void B_TextChanged(object sender, EventArgs e)
        {
        }

        private void P_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pole_Click(object sender, EventArgs e)
        {
        }

        private void side2_Click(object sender, EventArgs e)
        {
        }
    }
}
