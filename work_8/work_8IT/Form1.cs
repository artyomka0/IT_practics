using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace work_8IT
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      CreateChart();

      CalcFunction();

      chart.Series[0].Points.DataBindXY(x, y1);
      chart.Series[1].Points.DataBindXY(x, y2);


      InitializeComponent();
    }

    private void chart1_MouseWheel(object sender, MouseEventArgs e)
    {
      var chart = (Chart)sender;
      var xAxis = chart.ChartAreas[0].AxisX;
      var yAxis = chart.ChartAreas[0].AxisY;

      try
      {
        if (e.Delta < 0) // Scrolled down.
        {
          xAxis.ScaleView.ZoomReset();
          yAxis.ScaleView.ZoomReset();
        }
        else if (e.Delta > 0) // Scrolled up.
        {
          var xMin = xAxis.ScaleView.ViewMinimum;
          var xMax = xAxis.ScaleView.ViewMaximum;
          var yMin = yAxis.ScaleView.ViewMinimum;
          var yMax = yAxis.ScaleView.ViewMaximum;

          var posXStart = xAxis.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
          var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;
          var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4;
          var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4;

          xAxis.ScaleView.Zoom(posXStart, posXFinish);
          yAxis.ScaleView.Zoom(posYStart, posYFinish);
        }
      }
      catch { }
    }

    private double XMin = 0;
private double XMax = 3*Math.PI;

private double Step = (Math.PI * 2) / 10;

    private double[] x;

    private double[] y1;
    private double[] y2;
    //private double[] y3;
    Chart chart;
    private void CalcFunction()
    {
      int count = (int)Math.Ceiling((XMax - XMin) / Step)
      + 1;
      x = new double[count];
      y1 = new double[count];
      y2 = new double[count];
      //y3 = new double[count];
      for (int i = 0; i < count; i++)
      {
        x[i] = XMin + Step * i;
        y1[i] = Math.Sin(x[i]);
        y2[i] = (Math.Sqrt(3 + Math.Log(x[i]) + 15 - x[i])) / (1 + Math.Sin((2 + x[i] * x[i]) / (1 + x[i])));
      }
    }

    private void CreateChart()
    {
      chart = new Chart();
      chart.Parent = this;
      chart.SetBounds(0, 0, ClientSize.Width + 1500,
      ClientSize.Height + 500);

      ChartArea area = new ChartArea();
      area.Name = "myGraph";
      area.AxisX.Minimum = XMin;
      area.AxisX.Maximum = XMax;
      area.AxisX.MajorGrid.Interval = Step;
      chart.ChartAreas.Add(area);
      chart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
      chart.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
      chart.MouseWheel += chart1_MouseWheel;

      // Создаём объект для первого графика
      Series series1 = new Series();
      // Ссылаемся на область для построения графика
      series1.ChartArea = "myGraph";
      // Задаём тип графика - сплайны
      series1.ChartType = SeriesChartType.Spline;
      // Указываем ширину линии графика
      series1.BorderWidth = 3;
      // Название графика для отображения в легенде
      series1.LegendText = "sin(x)";
      // Добавляем в список графиков диаграммы
      chart.Series.Add(series1);
      // Аналогичные действия для второго графика
      
      Series series2 = new Series();
      series2.ChartArea = "myGraph";
      series2.ChartType = SeriesChartType.Spline;
      series2.BorderWidth = 3;
      series2.LegendText = "my function";
      chart.Series.Add(series2);
      
      //======/*================
      /*
      Series series3 = new Series();
      series3.ChartArea = "myGraph";
      series3.ChartType = SeriesChartType.Spline;
      series3.BorderWidth = 3;
      series3.LegendText = "my function";
      chart.Series.Add(series3);
      */
      // Создаёмлегенду, котораябудетпоказыватьназвания
      Legend legend = new Legend();
      chart.Legends.Add(legend);
    }

    

        private void chart1_Click(object sender, EventArgs e)
        {
      for(;;)
      {

      }
        }
    }
}
