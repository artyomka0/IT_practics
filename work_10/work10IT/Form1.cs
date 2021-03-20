using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace work10IT
{
  public partial class Form1 : Form
  {
    private int x1, y1, x2, y2, r;
    private double a;
    private Pen pen = new Pen(Color.DarkRed, 2);
    Point[] points = {
  new Point(20+500,60+500),
  new Point(70+500,10+500),
  new Point(50+500,80+500),
  new Point(30+500,10+500),
  new Point(80+500,60+500),
};

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Paint(object sender, PaintEventArgs e)
    {
      Graphics g = e.Graphics;
      g.DrawLine(pen, x1, y1, x2, y2);
      g.DrawPolygon(pen, points);
    }


    private void Form1_Load(object sender, EventArgs e)
        {
      /*
       * x1 = ClientSize.Width / 2;
      y1 = ClientSize.Height / 2;
      r = 150;
      a = 0; 
      x2 = x1 + (int)(r * Math.Cos(a));
      y2 = y1 - (int)(r * Math.Sin(a));
      */
    }

    private void timer3_Tick(object sender, EventArgs e)
    {
      /*
      a -= 0.1;
      x2 = x1 + (int)(r * Math.Cos(a));
      y2 = y1 - (int)(r * Math.Sin(a));
      */
      Random rnd = new Random();
      int a = rnd.Next(-50,50);
      int b = rnd.Next(-50,50);
      Size size = new Size(a,b);
      points[0] = Point.Add(points[0], size);
      points[1] = Point.Add(points[1], size);
      points[2] = Point.Add(points[2], size);
      points[3] = Point.Add(points[3], size);
      points[4] = Point.Add(points[4], size);
      Invalidate(); 
    }
  }

}
