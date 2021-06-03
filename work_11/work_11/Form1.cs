﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work_11
{
  public partial class Form1 : Form
  {

    private Bitmap bmp;
    private Pen blackPen;
    private Graphics g;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      blackPen = new Pen(Color.Black, 4); //подготавливаем перо для рисования
    }
    private void button1_Click(object sender, EventArgs e)
    {
      OpenFileDialog dialog = new OpenFileDialog(); //описываем и порождаем объект dialog класса OpenFileDialog
                                                    //задаем расширения файлов 
      dialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
      if (dialog.ShowDialog() == DialogResult.OK)//вызываем диалоговое окно и проверяем выбран ли файл
      {
        Image image = Image.FromFile(dialog.FileName); //Загружаем в image изображение из выбранного файла
        int width = image.Width;
        int height = image.Height;
        pictureBox1.Width = width;
        pictureBox1.Height = height;

        bmp = new Bitmap(image, width, height); //создаем и загружаем из image изображение в формате bmp

        pictureBox1.Image = bmp; //записываем изображение в формате bmp в pictureBox1
        g = Graphics.FromImage(pictureBox1.Image); //подготавливаем объект Graphics для рисования в pictureBox1
        label2.Text = "   ";
      }
    }
    private void button2_Click(object sender, EventArgs e)
    { //сохранение файла
      SaveFileDialog savedialog = new SaveFileDialog();//описываем и порождаем объект savedialog 
                                                       //задаем свойства для savedialog
      savedialog.Title = "Сохранить картинку как ...";
      savedialog.OverwritePrompt = true;
      savedialog.CheckPathExists = true;
      savedialog.Filter =
          "Bitmap File(*.bmp)|*.bmp|" +
          "GIF File(*.gif)|*.gif|" +
          "JPEG File(*.jpg)|*.jpg|" +
          "TIF File(*.tif)|*.tif|" +
          "PNG File(*.png)|*.png";
      savedialog.ShowHelp = true;
      if (savedialog.ShowDialog() == DialogResult.OK)
      {
        string fileName = savedialog.FileName;
        string strFilExtn =
            fileName.Remove(0, fileName.Length - 3);
        switch (strFilExtn)
        {
          case "bmp":
            bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
            break;
          case "jpg":
            bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            break;
          case "gif":
            bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Gif);
            break;
          case "tif":
            bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Tiff);
            break;
          case "png":
            bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
            break;
          default:
            break;
        }
      }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      for (int i = 0; i < bmp.Width; i++)
        for (int j = 0; j < bmp.Height; j++)
        {
          int R = bmp.GetPixel(i, j).R;
          int G = bmp.GetPixel(i, j).G;
          int B = bmp.GetPixel(i, j).B;

          if (B < 5 && G < 5 && R < 5 )
          {
            Color p = Color.FromArgb(1, 1, 1);
            bmp.SetPixel(i, j, p);
          }
          
        }
      label2.Text = "Task complite!";
      Refresh();
    }



  }
}
