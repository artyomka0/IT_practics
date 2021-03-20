using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      double x = Convert.ToDouble(textBox1.Text);
      textBox2.Text = "Результаты работы программы Михайлова А.А. " + Environment.NewLine;
      textBox2.Text += "При x = " + textBox1.Text + Environment.NewLine;
      int n = 0;
      if (radioButton2.Checked) n = 1;
      else if (radioButton3.Checked) n = 2;
      // Вычисление U
      double u;
      switch (n)
      {
        case 0:
          if (x >= 3) u = Math.Sinh(1 / x);
          else if (x >= 1) u = Math.Sinh(3 * x);
          else u = Math.Sinh(x * x);
          textBox2.Text += "y = " + Convert.ToString(u) + Environment.NewLine;
          break;
        case 1:
          if (x >= 3) u = Math.Cosh(1 / x);
          else if (x >= 1) u = Math.Cosh(3 * x);
          else u = Math.Cosh(x * x);
          textBox2.Text += "y = " + Convert.ToString(u) + Environment.NewLine;
          break;
        case 2:
          if (x >= 3) u = Math.Exp(1 / x);
          else if (x >= 1) u = Math.Exp(3 * x);
          else u = Math.Exp(x * x);
          textBox2.Text += "y = " + Convert.ToString(u) + Environment.NewLine;
          break;
        default:
          textBox2.Text += "Решение не найдено" + Environment.NewLine;
          break;

      }
    }
  }
}
