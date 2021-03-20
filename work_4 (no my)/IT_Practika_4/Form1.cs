using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Practika_4
{
    
    public partial class Form1 : Form
	{
        double Factorial(double xx)
        {
            double res = 1;
            for (double i = xx; i > 1; i--) res *= i;
            return res;
        }
        public Form1()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
            Double n = Convert.ToDouble(textBox1.Text);
            Double eps = Convert.ToDouble(textBox1.Text);
            int m = 0;
            if (radioButton2.Checked) m = 1;
            double s = 0, p = 1, ch;
            double i = 0;
      double num = i + 1;
      switch (m)
            {
                case 0:
          
                    ch = Math.Sqrt( i + 2) / ( 1 + Factorial(num));
                    while (ch >= eps || i > 5)
                    {
            num = i + 1;
            ch = Math.Sqrt(i + 2) / (1 + Factorial(num));
            s += ch;
                        i++;
                    }
                    textBox2.Text += "При eps = " + textBox1.Text + Environment.NewLine;
                    textBox2.Text += "Расчет суммы ряда S = " + Convert.ToString(s) + Environment.NewLine;
                    break;
                case 1:
                    for (i = 1; i <= n; i++)
                    {
            ch = Factorial(2*i + 1)/ Math.Sqrt(i + 2);
            p *= ch;
                    }
                    textBox2.Text += "При m = " + textBox1.Text + Environment.NewLine;
                    textBox2.Text += "Расчет произведения ряда P = " + Convert.ToString(p) + Environment.NewLine;
                    break;
            }

        }
    }
}
