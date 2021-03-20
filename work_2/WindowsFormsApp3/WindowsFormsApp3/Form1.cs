using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3        //var 6
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    private void textBox1_TextChanged(object sender, EventArgs e) { }
    private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }
    private void Form1_Load(object sender, EventArgs e)
    {
      textBox1.Text = "2";
      // Вывод строки в многострочный редактор
      textBox2.Text = "Практическая работа №2 Михайлов А.А.";
      textBox2.Text += Environment.NewLine + "Рассчитать значение выражения y=(sqrt(3 + ln x + 15 -x)/ 1 + sin (2 + x^2)/ 1+x";

    }

  

    private void button1_Click(object sender, EventArgs e)
    {
            double x = 0;
            // Считываниезначения X
            if (textBox1.Text == "") textBox1.Text = "0";                         
      x = double.Parse(textBox1.Text);
      // Выводзначения X вокно
      textBox2.Text += Environment.NewLine +
"При x = " + x.ToString();
      // Вычисляем арифметическое выражение
      double y = (Math.Sqrt(3 + Math.Log(x) + 15 - x)) /(1  + Math.Sin((2 + x*x)/(1 + x)));

      // Выводим результат в окно
      textBox2.Text += Environment.NewLine +
"Результат y = " + y.ToString();

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

		private void Form1_Load_1(object sender, EventArgs e)
		{
            textBox1.Text = "2";
            // Вывод строки в многострочный редактор
            textBox2.Text = "Практическая работа №2 Михайлов А.А.";
            textBox2.Text += Environment.NewLine + "Рассчитать значение выражения y=(sqrt(3 + ln x + 15 -x)/ 1 + sin (2 + x^2)/ 1+x";
        }
	}
}

