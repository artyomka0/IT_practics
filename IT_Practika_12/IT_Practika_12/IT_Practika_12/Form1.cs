using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Practika_12
{
	public partial class Form1 : Form  //Вариант 8
	{
		double[] x = {5,5.2,5.4,5.6,5.8,6};
		double[] y = {3,2,5,2,2,3};
		
		public Form1()
		{
			InitializeComponent();
		}
		public double S(int count) 
		{
			double s=0;
			for (int i = 0; i < 6; i++) s += Math.Pow(x[i], count);
			return s;
		}
		public double b(int count)
		{
			double s = 0;
			for (int i = 0; i < 6; i++) s += y[i]*Math.Pow(x[i], count);
			return s;
		}
		public double C(int count)
		{
			double a = 0;
			if ((count == 3) || (count == 6))
			{
				a = b(count / 3) - (b(0) * S(2 + count / 3)) / S(2);
			}
			if ((count == 1) || (count == 2))
			{
				a = S(count) - (S(count-1) * S(3)) / S(2);
			}
			if ((count == 4) || (count == 5))
			{
				a = S(count-2) - (S(count - 4) * S(4)) / S(2);
			}
			return a;
		}
		public double polin1_A0()
		{
			double a = (b(1)*S(1)-b(0)*S(2))/(S(1)*S(1)-S(2)*S(0));
			return a;
		}
		public double polin1_A1()
		{
			double a = (b(0) - S(0) * polin1_A0()) / S(1);
			return a;
		}
		
		public double polin2_A0()
		{
			double a = (C(6)*C(2)-C(5)*C(3))/(C(2)*C(4)-C(5)*C(1));
			return a;
		}
		public double polin2_A1()
		{
			double a = (C(3)-C(1)*polin2_A0())/C(2);
			return a;
		}
		public double polin2_A2()
		{
			double a =(b(0)-S(1)*polin2_A1()-S(0)*polin2_A0())/S(2);
			return a;
		}
		private void chart1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e) // Полин 1
		{
			dataGridView2.RowCount = 2; //Указываем количество строк	
			dataGridView2.ColumnCount = 3; //Указываем количество столбцов			
			dataGridView2.Columns[0].HeaderCell.Value = "матрица системы 1";

			for (int i = 0; i < 2; i++)
				for (int j = 0; j < 3; j++)
				{
					if ((j == 0) && (i == 0))
						dataGridView2.Rows[i].Cells[j].Value = Convert.ToString(S(0));
					if ((j == 1) && (i == 0))
						dataGridView2.Rows[i].Cells[j].Value = Convert.ToString(S(1));
					if ((j == 2) && (i == 0))
						dataGridView2.Rows[i].Cells[j].Value = Convert.ToString(b(0));
					if ((j == 0) && (i == 1))
						dataGridView2.Rows[i].Cells[j].Value = Convert.ToString(S(1));
					if ((j == 1) && (i == 1))
						dataGridView2.Rows[i].Cells[j].Value = Convert.ToString(S(2));
					if ((j == 2) && (i == 1))
						dataGridView2.Rows[i].Cells[j].Value = Convert.ToString(b(1));

				}
		}

		private void button2_Click(object sender, EventArgs e) // Полин 2
		{
			dataGridView4.RowCount = 3; //Указываем количество строк	
			dataGridView4.ColumnCount = 4; //Указываем количество столбцов	
			dataGridView4.Columns[0].HeaderCell.Value = "матрица системы 2";
			for (int i = 0; i < 3; i++)
				for (int j = 0; j < 4; j++)
				{					
						if((i==0)&&	(j!=3))
						dataGridView4.Rows[i].Cells[j].Value = Convert.ToString(S(j));
						if ((i == 1) && (j != 3))
						dataGridView4.Rows[i].Cells[j].Value = Convert.ToString(S(j+1));
						if ((i == 2) && (j != 3))
						dataGridView4.Rows[i].Cells[j].Value = Convert.ToString(S(j+2));
						if (j==3)
						dataGridView4.Rows[i].Cells[j].Value = Convert.ToString(b(i));
				}
		}

		private void button3_Click(object sender, EventArgs e) //Начальные точки
		{
			chart1.Series[2].Points.DataBindXY(x, y);
		}

		private void button4_Click(object sender, EventArgs e) // полин 1 граф
		{
			double[] y1=new double[6];
			for	(int i=0; i < 6; i++)
			{
				y1[i] = polin1_A0() + polin1_A1()* x[i];								
			}
			chart1.Series[0].Points.DataBindXY(x, y1);					
		}

		private void button5_Click(object sender, EventArgs e) // полин 2 граф
		{
			double[] y1 = new double[6];
			for (int i = 0; i < 6; i++)
			{
				y1[i] = polin2_A0() + polin2_A1() * x[i]+ polin2_A2()* x[i]* x[i];
			}
			chart1.Series[1].Points.DataBindXY(x, y1);
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			dataGridView1.RowCount = 6;	
			dataGridView1.ColumnCount = 2;
			dataGridView1.Columns[0].HeaderCell.Value = "х";
			dataGridView1.Columns[1].HeaderCell.Value = "у";
			for (int i = 0; i < 6; i++)
				for (int j = 0; j < 2; j++)
				{
					if (j == 0)
						dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(x[i]);
					else
						dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(y[i]);
				}
			dataGridView3.RowCount = 2;
			dataGridView3.ColumnCount = 2;
			dataGridView3.Columns[0].HeaderCell.Value = "коэффицент";
			dataGridView3.Columns[1].HeaderCell.Value = "значение";

			for (int i = 0; i < 2; i++)
				for (int j = 0; j < 2; j++)
				{
					if ((j == 0) && (i == 0))
						dataGridView3.Rows[i].Cells[j].Value = "a0:";
					if ((j == 1) && (i == 0))
						dataGridView3.Rows[i].Cells[j].Value = Convert.ToString(polin1_A0());
					if ((j == 0) && (i == 1))
						dataGridView3.Rows[i].Cells[j].Value = "a1:";
					if ((j == 1) && (i == 1))
						dataGridView3.Rows[i].Cells[j].Value = Convert.ToString(polin1_A1());
					
				}
			dataGridView5.RowCount = 3;
			dataGridView5.ColumnCount = 2;
			dataGridView5.Columns[0].HeaderCell.Value = "коэффицент";
			dataGridView5.Columns[1].HeaderCell.Value = "значение";
			for (int i = 0; i < 3; i++)
				for (int j = 0; j < 2; j++)
				{
					if ((j == 0) && (i == 0))	
						dataGridView5.Rows[i].Cells[j].Value = "a0";
					if ((j == 1) && (i == 0))
						dataGridView5.Rows[i].Cells[j].Value = Convert.ToString(polin2_A0());
					if ((j == 0) && (i == 1))
						dataGridView5.Rows[i].Cells[j].Value = "a1";
					if ((j == 1) && (i == 1))
						dataGridView5.Rows[i].Cells[j].Value = Convert.ToString(polin2_A1());
					if ((j == 0) && (i == 2))
						dataGridView5.Rows[i].Cells[j].Value = "a2";
					if ((j == 1) && (i == 2))
						dataGridView5.Rows[i].Cells[j].Value = Convert.ToString(polin2_A2());
				}
		}

		private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
