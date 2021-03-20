using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work7IT
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

        private void button1_Click(object sender, EventArgs e)
        {
      int H = 5;
      int L = 5;
      dataGridView1.RowCount = H;
      dataGridView1.ColumnCount = L; 
      int[,] a = new int[H, L];
      int i,j;
      Random rand = new Random();
      for (i = 0; i < H-1; i++)
        for (j = 0; j < L; j++)
          a[i, j] = rand.Next(-100, 100);
      
      for (i = 0; i < H-1; i++)
        for (j = 0; j < L; j++)
          dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);
      /*
      int m = int.MinValue;
      for (i = 0; i < H; i++)
        if (a[i, L - 1 - i] > m) m = a[i, L - 1 - i];
      textBox1.Text = Convert.ToString(m);
      Для столбцов матрицы с четными номерами найти максимальный элемент, для столбцов с нечетными - минимальный.
      СТРОКА СТОЛБЕЦ
      */
    }

    private void button2_Click(object sender, EventArgs e)
    {
      int H = 5;
      int L = 5;
      dataGridView1.RowCount = H;
      dataGridView1.ColumnCount = L;
      int[,] a = new int[H, L];
      int i, j;
      for (i = 0; i < H-1; i++)
        for (j = 0; j < L; j++)
         a[i, j] = Convert.ToInt16(dataGridView1.Rows[i].Cells[j].Value);
      for (j = 0; j < L; j++)
      {
        
        //{
          if (j % 2 != 0)
          {
          int max = int.MinValue;
          for (i = 0; i < H - 1; i++)
          {
            if (a[i, j] > max)
            {
              max = a[i, j];
            }
            dataGridView1.Rows[H - 1].Cells[j].Value = Convert.ToString(max);
          }
          }
          if (j % 2 == 0)
        {
          int min = int.MaxValue;
          for (i = 0; i < H - 1; i++)
          {
            if (a[i, j] < min)
            {
              min = a[i, j];
            }
            dataGridView1.Rows[H - 1].Cells[j].Value = Convert.ToString(min);
          }
          }
        //}
      }

    }
  }
}
