
namespace IT_Practika_12
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.dataGridView2 = new System.Windows.Forms.DataGridView();
      this.dataGridView3 = new System.Windows.Forms.DataGridView();
      this.dataGridView4 = new System.Windows.Forms.DataGridView();
      this.dataGridView5 = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
      this.SuspendLayout();
      // 
      // chart1
      // 
      this.chart1.BorderlineWidth = 3;
      chartArea2.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea2);
      legend2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Left;
      legend2.Name = "Legend1";
      this.chart1.Legends.Add(legend2);
      this.chart1.Location = new System.Drawing.Point(13, 313);
      this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.chart1.Name = "chart1";
      series4.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
      series4.BorderWidth = 3;
      series4.ChartArea = "ChartArea1";
      series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
      series4.LabelBorderWidth = 3;
      series4.Legend = "Legend1";
      series4.Name = "Полином первой степени";
      series5.BorderWidth = 3;
      series5.ChartArea = "ChartArea1";
      series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
      series5.LabelBorderWidth = 3;
      series5.Legend = "Legend1";
      series5.Name = "Полином второй степени";
      series6.BorderWidth = 3;
      series6.ChartArea = "ChartArea1";
      series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
      series6.LabelBorderWidth = 3;
      series6.Legend = "Legend1";
      series6.Name = "Начальные данные";
      this.chart1.Series.Add(series4);
      this.chart1.Series.Add(series5);
      this.chart1.Series.Add(series6);
      this.chart1.Size = new System.Drawing.Size(884, 363);
      this.chart1.TabIndex = 0;
      this.chart1.Text = "chart1";
      this.chart1.Click += new System.EventHandler(this.chart1_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(404, 13);
      this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(111, 118);
      this.button1.TabIndex = 1;
      this.button1.Text = "Решить сис 1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(404, 154);
      this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(111, 139);
      this.button2.TabIndex = 2;
      this.button2.Text = "Решить сис 2";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(622, 418);
      this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(250, 50);
      this.button3.TabIndex = 3;
      this.button3.Text = "Отобразить начальные точки";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(622, 505);
      this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(250, 44);
      this.button4.TabIndex = 4;
      this.button4.Text = "Построить полином 1ой степени";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // button5
      // 
      this.button5.Location = new System.Drawing.Point(622, 577);
      this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(250, 40);
      this.button5.TabIndex = 5;
      this.button5.Text = "Построить полином 2ой степени";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new System.EventHandler(this.button5_Click);
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(918, 313);
      this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersWidth = 51;
      this.dataGridView1.Size = new System.Drawing.Size(363, 363);
      this.dataGridView1.TabIndex = 6;
      this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
      // 
      // dataGridView2
      // 
      this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView2.Location = new System.Drawing.Point(541, 15);
      this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.dataGridView2.Name = "dataGridView2";
      this.dataGridView2.RowHeadersWidth = 51;
      this.dataGridView2.Size = new System.Drawing.Size(740, 116);
      this.dataGridView2.TabIndex = 7;
      this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
      // 
      // dataGridView3
      // 
      this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView3.Location = new System.Drawing.Point(13, 13);
      this.dataGridView3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.dataGridView3.Name = "dataGridView3";
      this.dataGridView3.RowHeadersWidth = 51;
      this.dataGridView3.Size = new System.Drawing.Size(368, 118);
      this.dataGridView3.TabIndex = 8;
      this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
      // 
      // dataGridView4
      // 
      this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView4.Location = new System.Drawing.Point(541, 154);
      this.dataGridView4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.dataGridView4.Name = "dataGridView4";
      this.dataGridView4.RowHeadersWidth = 51;
      this.dataGridView4.Size = new System.Drawing.Size(740, 139);
      this.dataGridView4.TabIndex = 9;
      this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
      // 
      // dataGridView5
      // 
      this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView5.Location = new System.Drawing.Point(13, 154);
      this.dataGridView5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.dataGridView5.Name = "dataGridView5";
      this.dataGridView5.RowHeadersWidth = 51;
      this.dataGridView5.Size = new System.Drawing.Size(368, 139);
      this.dataGridView5.TabIndex = 10;
      this.dataGridView5.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellContentClick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1312, 690);
      this.Controls.Add(this.dataGridView5);
      this.Controls.Add(this.dataGridView4);
      this.Controls.Add(this.dataGridView3);
      this.Controls.Add(this.dataGridView2);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.button5);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.chart1);
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
      this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridView dataGridView3;
		private System.Windows.Forms.DataGridView dataGridView4;
		private System.Windows.Forms.DataGridView dataGridView5;
	}
}

