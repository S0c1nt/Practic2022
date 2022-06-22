using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            if (radioButton1.Checked == true)
            {
                textBox3.Text = Convert.ToString(a % b);
            }
            if (radioButton2.Checked == true)
            {
                textBox3.Text = Convert.ToString(Math.Pow(a, b));
            }
            if (radioButton3.Checked == true)
            {
                textBox3.Text = Convert.ToString(a) + Convert.ToString(b);
            }
            if (radioButton4.Checked == true)
            {
                textBox3.Text = Convert.ToString(a/b);
            }
        }
    }
}
