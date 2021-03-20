using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Practika_9
{

	public partial class Form1 : Form
	{
		Point[] points = {
	new Point(400, 160),
	new Point(320, 270),
	new Point(480, 270),
};
		Point[] points2 = {
	new Point(320, 180),
	new Point(480, 180),
	new Point(400, 290),
};
		Pen pen = new Pen(Color.Blue, 4);
		Brush brush = Brushes.White;
		Brush brush1 = Brushes.Blue;
		Brush brush2 = Brushes.Gray;
		Rectangle rectangle = new Rectangle(0, 0, 2000, 150);
		Rectangle rectangle1 = new Rectangle(0, 150, 2000, 150);
		Rectangle rectangle2 = new Rectangle(0, 300, 2000, 150);
		public Form1()
		{
			/*
			for (int i = 0; i < 20; i++)
			{
				int xPos;
				if (i % 2 == 0)
				{
					xPos = 10;
				}
				else
				{
					xPos = 400;
				}
				points[i] = new Point(xPos, 10 * i);
			}
			*/
			/*
			points[1] = new Point(200,200);
			points[2] = new Point(150,300);
			points[3] = new Point(150,400);
			points[4] = new Point(200, 200);
			*/

			InitializeComponent();
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			
			g.FillRectangle(brush1, rectangle);
			g.FillRectangle(brush, rectangle1);
			g.FillRectangle(brush1, rectangle2);
			g.DrawPolygon(pen, points);
			g.DrawPolygon(pen, points2);
			//g.FillPolygon(brush2, points);
			//g.DrawPie(pen, Single, Single, Single, Single, Single, Single);
		}
	}
}
