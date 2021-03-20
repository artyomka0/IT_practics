using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work6_7IT
{
  public partial class Form1 : Form
  {
    int[] Mas = new int[15];
    public Form1()
    {
      InitializeComponent();
    }

        private void button1_Click(object sender, EventArgs e)
        {
      Random rand = new Random();
      textBox1.Text = "";
      for (int i = 0; i < 15; i++)
      {
        Mas[i] = rand.Next(-50, 50);
        textBox1.Text += "Mas[" + Convert.ToString(i) + "] = "
            + Convert.ToString(Mas[i]) + Environment.NewLine;
      }

    }

    private void button2_Click(object sender, EventArgs e)
    {
      textBox2.Text = "";
      int sum = 0;
      int p = 1;
      for (int i = 0; i < 15; i++)
      {
        if (Mas[i] < 0) sum += Mas[i];
        if (Mas[i] > 0) p *= Mas[i];
      } 
      textBox2.Text += "сумма =" + Convert.ToString(sum) + Environment.NewLine + " произведение = "
                          + Convert.ToString(Math.Abs(p)) + Environment.NewLine;
    }


  }
}
