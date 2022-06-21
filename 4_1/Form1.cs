using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_1
{

public partial class Form1 : Form
    {
        public enum Credit
        {
            Summ = 1500000,
            platej = 5,
            SumPlat = 30000
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int dolg = (int)Credit.Summ;
            int pereplat = 0;

            dolg -= a;
            if (dolg <= 0)
            {
                MessageBox.Show("Кредит выплачен!");
            }
            if (a > (int)Credit.SumPlat)
            {
                pereplat = a - (int)Credit.SumPlat;
            }
            if (a < (int)Credit.SumPlat)
            {
                pereplat = (int)Credit.SumPlat - a;
            }

            label2.Text = "Остаток: " + dolg + "\nПереплата: " + pereplat;
        }
    }

}
