using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phosotshop_AP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int width;
        private int height;
        private void Odczyt_obrazka_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
                pictureBox2.Image = new Bitmap(open.FileName);
                width = pictureBox1.Image.Width;
                height = pictureBox1.Image.Height;
            }
        }

        private int sprawdzRGB(int x)
        {
            if (x > 255) return 255;
            else if (x < 0) return 0;
            else return x;
        }

        private void B_jasnosc_Click(object sender, EventArgs e)
        {
            int jasnosc = (int)Jasnosc.Value;
            Color k1;
            Bitmap b = (Bitmap)pictureBox1.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;
            double R, G, B;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    k1 = b.GetPixel(i,j);
                    R = sprawdzRGB(k1.R + jasnosc);
                    G = sprawdzRGB(k1.G + jasnosc);
                    B = sprawdzRGB(k1.B + jasnosc);
                    b2.SetPixel(i, j, Color.FromArgb((int)R,(int)G,(int)B));
                }
            }

            pictureBox2.Image = b2;
            pictureBox2.Refresh();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Oryginal_Click(object sender, EventArgs e)
        {
           
        }

        private void Negatyw_Click(object sender, EventArgs e)
        {
            Color k1;
            Bitmap b = (Bitmap)pictureBox1.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;
            double R, G, B;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    k1 = b.GetPixel(i, j);
                    R = sprawdzRGB(255 - k1.R);
                    G = sprawdzRGB(255 - k1.G);
                    B = sprawdzRGB(255 - k1.B);
                    b2.SetPixel(i, j, Color.FromArgb((int)R, (int)G, (int)B));
                }
            }

            pictureBox2.Image = b2;
            pictureBox2.Refresh();
        }

        private void Transformacja_potegowa_Click(object sender, EventArgs e)
        {
            Color k1;
            Bitmap b = (Bitmap)pictureBox1.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;
            double R, G, B;
            double n = (double)Potegowa_numeric.Value;
            double c = 1.2;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    k1 = b.GetPixel(i, j);
                    R = (c * Math.Pow((double)k1.R / 255, n)) * 255;
                    G = (c * Math.Pow((double)k1.G / 255, n)) * 255;
                    B = (c * Math.Pow((double)k1.B / 255, n)) * 255;
                    R = sprawdzRGB((int)R);
                    G = sprawdzRGB((int)G);
                    B = sprawdzRGB((int)B);
                    b2.SetPixel(i, j, Color.FromArgb((int)R, (int)G, (int)B));
                }
            }

            pictureBox2.Image = b2;
            pictureBox2.Refresh();
        }

        private void Odczytaj_img2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox3.Image = new Bitmap(open.FileName);
            }
        }

        private void Suma_Click(object sender, EventArgs e)
        {
            Color k1,k2;
            Bitmap b = (Bitmap)pictureBox1.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;
            Bitmap b3 = (Bitmap)pictureBox3.Image;
            double R, G, B;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    k1 = b.GetPixel(i, j);
                    k2 = b3.GetPixel(i, j);
                    R = sprawdzRGB(k1.R + k2.R);
                    G = sprawdzRGB(k1.G + k2.G);
                    B = sprawdzRGB(k1.B + k2.B);
                    b2.SetPixel(i, j, Color.FromArgb((int)R, (int)G, (int)B));
                }
            }

            pictureBox2.Image = b2;
            pictureBox2.Refresh();
        }

        private void Odejmowanie_Click(object sender, EventArgs e)
        {
            Color k1, k2;
            Bitmap b = (Bitmap)pictureBox1.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;
            Bitmap b3 = (Bitmap)pictureBox3.Image;
            double R, G, B;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    k1 = b.GetPixel(i, j);
                    k2 = b3.GetPixel(i, j);
                    R = ((double)k1.R / 255 + (double)k2.R / 255 - 1) * 255;
                    G = ((double)k1.G / 255 + (double)k2.G / 255 - 1) * 255;
                    B = ((double)k1.B / 255 + (double)k2.B / 255 - 1) * 255;
                    R = sprawdzRGB((int)R);
                    G = sprawdzRGB((int)G);
                    B = sprawdzRGB((int)B);
                    b2.SetPixel(i, j, Color.FromArgb((int)R, (int)G, (int)B));
                }
            }

            pictureBox2.Image = b2;
            pictureBox2.Refresh();
        }

        private void Roznica_Click(object sender, EventArgs e)
        {
            Color k1, k2;
            Bitmap b = (Bitmap)pictureBox1.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;
            Bitmap b3 = (Bitmap)pictureBox3.Image;
            double R, G, B;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    k1 = b.GetPixel(i, j);
                    k2 = b3.GetPixel(i, j);
                    R = Math.Abs(k1.R - k2.R);
                    G = Math.Abs(k1.G - k2.G);
                    B = Math.Abs(k1.B - k2.B);
                    R = sprawdzRGB((int)R);
                    G = sprawdzRGB((int)G);
                    B = sprawdzRGB((int)B);
                    b2.SetPixel(i, j, Color.FromArgb((int)R, (int)G, (int)B));
                }
            }

            pictureBox2.Image = b2;
            pictureBox2.Refresh();
        }

        private void Mnozenie_Click(object sender, EventArgs e)
        {
            Color k1, k2;
            Bitmap b = (Bitmap)pictureBox1.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;
            Bitmap b3 = (Bitmap)pictureBox3.Image;
            double R, G, B;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    k1 = b.GetPixel(i, j);
                    k2 = b3.GetPixel(i, j);
                    R = ((double)k1.R / 255 * (double)k2.R / 255) * 255;
                    G = ((double)k1.G / 255 * (double)k2.G / 255) * 255;
                    B = ((double)k1.B / 255 * (double)k2.B / 255) * 255;
                    R = sprawdzRGB((int)R);
                    G = sprawdzRGB((int)G);
                    B = sprawdzRGB((int)B);
                    b2.SetPixel(i, j, Color.FromArgb((int)R, (int)G, (int)B));
                }
            }

            pictureBox2.Image = b2;
            pictureBox2.Refresh();
        }

        private void Odw_mnozenie_Click(object sender, EventArgs e)
        {
            Color k1, k2;
            Bitmap b = (Bitmap)pictureBox1.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;
            Bitmap b3 = (Bitmap)pictureBox3.Image;
            double R, G, B;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    k1 = b.GetPixel(i, j);
                    k2 = b3.GetPixel(i, j);
                    R = (1 - (1 - (double)k1.R / 255) * (1 - (double)k2.R / 255)) * 255;
                    G = (1 - (1 - (double)k1.G / 255) * (1 - (double)k2.G / 255)) * 255;
                    B = (1 - (1 - (double)k1.B / 255) * (1 - (double)k2.B / 255)) * 255;
                    R = sprawdzRGB((int)R);
                    G = sprawdzRGB((int)G);
                    B = sprawdzRGB((int)B);
                    b2.SetPixel(i, j, Color.FromArgb((int)R, (int)G, (int)B));
                }
            }

            pictureBox2.Image = b2;
            pictureBox2.Refresh();
        }

        private void Negacja_Click(object sender, EventArgs e)
        {
            Color k1, k2;
            Bitmap b = (Bitmap)pictureBox1.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;
            Bitmap b3 = (Bitmap)pictureBox3.Image;
            double R, G, B;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    k1 = b.GetPixel(i, j);
                    k2 = b3.GetPixel(i, j);
                    R = (1 - Math.Abs(1 - (double)k1.R / 255 - (double)k2.R / 255)) * 255;
                    G = (1 - Math.Abs(1 - (double)k1.G / 255 - (double)k2.G / 255)) * 255;
                    B = (1 - Math.Abs(1 - (double)k1.B / 255 - (double)k2.B / 255)) * 255;
                    R = sprawdzRGB((int)R);
                    G = sprawdzRGB((int)G);
                    B = sprawdzRGB((int)B);
                    b2.SetPixel(i, j, Color.FromArgb((int)R, (int)G, (int)B));
                }
            }

            pictureBox2.Image = b2;
            pictureBox2.Refresh();
        }

        private void Ciemniejsze_Click(object sender, EventArgs e)
        {
            Color k1, k2;
            Bitmap b = (Bitmap)pictureBox1.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;
            Bitmap b3 = (Bitmap)pictureBox3.Image;
            double R, G, B;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    k1 = b.GetPixel(i, j);
                    k2 = b3.GetPixel(i, j);

                    if (k1.R < k2.R)
                        R = k1.R;
                    else
                        R = k2.R;
                    if (k1.G < k2.G)
                        G = k1.G;
                    else
                        G = k2.G;
                    if (k1.B < k2.B)
                        B = k1.B;
                    else
                        B = k2.B;

                    b2.SetPixel(i, j, Color.FromArgb((int)R, (int)G, (int)B));
                }
            }

            pictureBox2.Image = b2;
            pictureBox2.Refresh();
        }

        private void Jasniejsze_Click(object sender, EventArgs e)
        {
            Color k1, k2;
            Bitmap b = (Bitmap)pictureBox1.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;
            Bitmap b3 = (Bitmap)pictureBox3.Image;
            double R, G, B;
            double n = (double)Potegowa_numeric.Value;
            double c = 1.2;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    k1 = b.GetPixel(i, j);
                    k2 = b3.GetPixel(i, j);

                    if (k1.R > k2.R)
                        R = k1.R;
                    else
                        R = k2.R;
                    if (k1.G > k2.G)
                        G = k1.G;
                    else
                        G = k2.G;
                    if (k1.B > k2.B)
                        B = k1.B;
                    else
                        B = k2.B;

                    b2.SetPixel(i, j, Color.FromArgb((int)R, (int)G, (int)B));
                }
            }

            pictureBox2.Image = b2;
            pictureBox2.Refresh();
        }

        private void Wylaczenie_Click(object sender, EventArgs e)
        {
            Color k1, k2;
            Bitmap b = (Bitmap)pictureBox1.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;
            Bitmap b3 = (Bitmap)pictureBox3.Image;
            double R, G, B;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    k1 = b.GetPixel(i, j);
                    k2 = b3.GetPixel(i, j);
                    R = ((double)k1.R / 255 + (double)k2.R / 255 - 2 * (double)k1.R / 255 * (double)k2.R / 255) * 255;
                    G = ((double)k1.G / 255 + (double)k2.G / 255 - 2 * (double)k1.G / 255 * (double)k2.G / 255) * 255;
                    B = ((double)k1.B / 255 + (double)k2.B / 255 - 2 * (double)k1.B / 255 * (double)k2.B / 255) * 255;
                    R = sprawdzRGB((int)R);
                    G = sprawdzRGB((int)G);
                    B = sprawdzRGB((int)B);
                    b2.SetPixel(i, j, Color.FromArgb((int)R, (int)G, (int)B));
                }
            }

            pictureBox2.Image = b2;
            pictureBox2.Refresh();
        }

        private void Ostre_swiatlo_Click(object sender, EventArgs e)
        {
            Color k1, k2;
            Bitmap b = (Bitmap)pictureBox1.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;
            Bitmap b3 = (Bitmap)pictureBox3.Image;
            double R, G, B;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    k1 = b.GetPixel(i, j);
                    k2 = b3.GetPixel(i, j);

                    if (k2.R < 0.5) 
                        R = (2 * (double)k1.R/255 * (double)k2.R/255) * 255;
                    else
                        R = (1 - 2 * (1 - (double)k1.R / 255) * (1 - (double)k2.R / 255)) * 255;

                    if (k2.G < 0.5)
                        G = (2 * (double)k1.G / 255 * (double)k2.G / 255) * 255;
                    else
                        G = (1 - 2 * (1 - (double)k1.G / 255) * (1 - (double)k2.G / 255)) * 255;

                    if (k2.B < 0.5)
                        B = (2 * (double)k1.B / 255 * (double)k2.B / 255) * 255;
                    else
                        B = (1 - 2 * (1 - (double)k1.B / 255) * (1 - (double)k2.B / 255)) * 255;



                    R = sprawdzRGB((int)R);
                    G = sprawdzRGB((int)G);
                    B = sprawdzRGB((int)B);
                    b2.SetPixel(i, j, Color.FromArgb((int)R, (int)G, (int)B));
                }
            }

            pictureBox2.Image = b2;
            pictureBox2.Refresh();
        }

        private void Lagodne_swiatlo_Click(object sender, EventArgs e)
        {
            Color k1, k2;
            Bitmap b = (Bitmap)pictureBox1.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;
            Bitmap b3 = (Bitmap)pictureBox3.Image;
            double R, G, B;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    k1 = b.GetPixel(i, j);
                    k2 = b3.GetPixel(i, j);

                    if (k2.R < 0.5)
                        R = (2 * (double)k1.R / 255 * (double)k2.R / 255 + Math.Pow((double)k1.R/255, 2) * (1 - 2 * (double)k2.R / 255)) * 255;
                    else
                        R = (Math.Sqrt((double)k1.R / 255) * (2 * (double)k2.R / 255 - 1) + (2 * (double)k1.R/255) * (1 - (double)k2.R / 255)) * 255;

                    if (k2.G < 0.5)
                        G = (2 * (double)k1.G / 255 * (double)k2.G / 255 + Math.Pow((double)k1.G/255, 2) * (1 - 2 * (double)k2.G / 255)) * 255;
                    else
                        G = (Math.Sqrt((double)k1.G / 255) * (2 * (double)k2.G / 255 - 1) + (2 * (double)k1.G/255) * (1 - (double)k2.G / 255)) * 255;

                    if (k2.B < 0.5)
                        B = (2 * (double)k1.B / 255 * (double)k2.B / 255 + Math.Pow((double)k1.B/255, 2) * (1 - 2 * (double)k2.B / 255)) * 255;
                    else
                        B = (Math.Sqrt((double)k1.B / 255) * (2 * (double)k2.B / 255 - 1) + (2 * (double)k1.B/255) * (1 - (double)k2.B / 255)) * 255;

                    R = sprawdzRGB((int)R);
                    G = sprawdzRGB((int)G);
                    B = sprawdzRGB((int)B);
                    b2.SetPixel(i, j, Color.FromArgb((int)R, (int)G, (int)B));
                }
            }

            pictureBox2.Image = b2;
            pictureBox2.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Color k1, k2;
            Bitmap b = (Bitmap)pictureBox1.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;
            Bitmap b3 = (Bitmap)pictureBox3.Image;
            double R, G, B;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    k1 = b.GetPixel(i, j);
                    k2 = b3.GetPixel(i, j);

                    R = (((double)k1.R / 255) / (1 - (double)k2.R / 255)) * 255;
                    G = (((double)k1.G / 255) / (1 - (double)k2.G / 255)) * 255;
                    B = (((double)k1.B / 255) / (1 - (double)k2.B / 255)) * 255;

                    R = sprawdzRGB((int)R);
                    G = sprawdzRGB((int)G);
                    B = sprawdzRGB((int)B);
                    b2.SetPixel(i, j, Color.FromArgb((int)R, (int)G, (int)B));
                }
            }

            pictureBox2.Image = b2;
            pictureBox2.Refresh();
        }

        private void Wypalanie_Click(object sender, EventArgs e)
        {
            Color k1, k2;
            Bitmap b = (Bitmap)pictureBox1.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;
            Bitmap b3 = (Bitmap)pictureBox3.Image;
            double R, G, B;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    k1 = b.GetPixel(i, j);
                    k2 = b3.GetPixel(i, j);

                    R = (1 - (1 - (double)k1.R / 255) / (double)k2.R / 255) * 255;
                    G = (1 - (1 - (double)k1.G / 255) / (double)k2.G / 255) * 255;
                    B = (1 - (1 - (double)k1.B / 255) / (double)k2.B / 255) * 255;

                    R = sprawdzRGB((int)R);
                    G = sprawdzRGB((int)G);
                    B = sprawdzRGB((int)B);
                    b2.SetPixel(i, j, Color.FromArgb((int)R, (int)G, (int)B));
                }
            }

            pictureBox2.Image = b2;
            pictureBox2.Refresh();
        }

        private void Reflect_mode_Click(object sender, EventArgs e)
        {
            Color k1, k2;
            Bitmap b = (Bitmap)pictureBox1.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;
            Bitmap b3 = (Bitmap)pictureBox3.Image;
            double R, G, B;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    k1 = b.GetPixel(i, j);
                    k2 = b3.GetPixel(i, j);

                    R = (Math.Pow((double)k1.R / 255, 2) / (1 - (double)k2.R / 255)) * 255;
                    G = (Math.Pow((double)k1.G / 255, 2) / (1 - (double)k2.G / 255)) * 255;
                    B = (Math.Pow((double)k1.B / 255, 2) / (1 - (double)k2.B / 255)) * 255;

                    R = sprawdzRGB((int)R);
                    G = sprawdzRGB((int)G);
                    B = sprawdzRGB((int)B);
                    b2.SetPixel(i, j, Color.FromArgb((int)R, (int)G, (int)B));
                }
            }

            pictureBox2.Image = b2;
            pictureBox2.Refresh();
        }

        private void Przezroczystosc_Click(object sender, EventArgs e)
        {
            Color k1, k2;
            Bitmap b = (Bitmap)pictureBox1.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;
            Bitmap b3 = (Bitmap)pictureBox3.Image;
            double R, G, B;
            double alpha = (double)Przezroczystosc_num.Value;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    k1 = b.GetPixel(i, j);
                    k2 = b3.GetPixel(i, j);

                    R = ((1 - alpha) * (double)k2.R / 255 + alpha * (double)k1.R / 255) * 255;
                    G = ((1 - alpha) * (double)k2.G / 255 + alpha * (double)k1.G / 255) * 255;
                    B = ((1 - alpha) * (double)k2.B / 255 + alpha * (double)k1.B / 255) * 255;

                    R = sprawdzRGB((int)R);
                    G = sprawdzRGB((int)G);
                    B = sprawdzRGB((int)B);
                    b2.SetPixel(i, j, Color.FromArgb((int)R, (int)G, (int)B));
                }
            }

            pictureBox2.Image = b2;
            pictureBox2.Refresh();
        }

        private void Kontrast_Click(object sender, EventArgs e)
        {
            Color k1;
            Bitmap b = (Bitmap)pictureBox1.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;
            double R, G, B;
            int c = (int)Kontrast_num.Value;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    k1 = b.GetPixel(i, j);

                    if (c > 0 && c < 127)
                    {
                        if (k1.R < 127)
                        {
                            R = ((127 - c) / 127) * k1.R;
                            G = ((127 - c) / 127) * k1.G;
                            B = ((127 - c) / 127) * k1.B;
                        }
                        else
                        {
                            R = ((127 - c) / 127) * k1.R + 2 * c;
                            G = ((127 - c) / 127) * k1.G + 2 * c;
                            B = ((127 - c) / 127) * k1.B + 2 * c;
                        }
                    }

                    else
                    {
                        if (k1.R < 127 + c)
                        {
                            R = (127 / (127 + c)) * k1.R;
                            G = (127 / (127 + c)) * k1.G;
                            B = (127 / (127 + c)) * k1.B;
                        }

                        else if (k1.R > 127 - c)
                        {
                            R = (127 * k1.R + 255 * c) / (127 + c);
                            G = (127 * k1.G + 255 * c) / (127 + c);
                            B = (127 * k1.B + 255 * c) / (127 + c);
                        }
                        else
                        {
                            R = 127;
                            G = 127;
                            B = 127;
                        }
                    }


                    R = sprawdzRGB((int)R);
                    G = sprawdzRGB((int)G);
                    B = sprawdzRGB((int)B);
                    b2.SetPixel(i, j, Color.FromArgb((int)R, (int)G, (int)B));
                }
            }

            pictureBox2.Image = b2;
            pictureBox2.Refresh();
        }

        private void Filtr_Click(object sender, EventArgs e)
        {
            Color k1,k2,k3,k4,k5,k6,k7,k8,k9;
            int f1 = Int32.Parse(textBox1.Text);
            int f2 = Int32.Parse(textBox2.Text);
            int f3 = Int32.Parse(textBox3.Text);
            int f4 = Int32.Parse(textBox4.Text);
            int f5 = Int32.Parse(textBox5.Text);
            int f6 = Int32.Parse(textBox6.Text);
            int f7 = Int32.Parse(textBox7.Text);
            int f8 = Int32.Parse(textBox8.Text);
            int f9 = Int32.Parse(textBox9.Text);
            double suma = f1 + f2 + f3 + f4 + f5 + f6 + f7 + f8 + f9;
            Bitmap b = (Bitmap)pictureBox1.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;
            double R, G, B;
            for (int i = 1; i < width-1; i++)
            {
                for (int j = 1; j < height-1; j++)
                {
                    k1 = b.GetPixel(i-1, j-1);
                    k2 = b.GetPixel(i - 1, j);
                    k3 = b.GetPixel(i - 1, j + 1);
                    k4 = b.GetPixel(i, j - 1);
                    k5 = b.GetPixel(i, j );
                    k6 = b.GetPixel(i , j + 1);
                    k7 = b.GetPixel(i + 1, j - 1);
                    k8 = b.GetPixel(i + 1, j );
                    k9 = b.GetPixel(i + 1, j + 1);

                    if (suma != 0)
                    {
                        R = (k1.R * f1 + k2.R * f2 + k3.R * f3 + k4.R * f4 + k5.R * f5 + k6.R * f6 + k7.R * f7 + k8.R * f8 + k9.R * f9) / suma;
                        G = (k1.G * f1 + k2.G * f2 + k3.G * f3 + k4.G * f4 + k5.G * f5 + k6.G * f6 + k7.G * f7 + k8.G * f8 + k9.G * f9) / suma;
                        B = (k1.B * f1 + k2.B * f2 + k3.B * f3 + k4.B * f4 + k5.B * f5 + k6.B * f6 + k7.B * f7 + k8.B * f8 + k9.B * f9) / suma;
                    }
                    else
                    {
                        R = (k1.R * f1 + k2.R * f2 + k3.R * f3 + k4.R * f4 + k5.R * f5 + k6.R * f6 + k7.R * f7 + k8.R * f8 + k9.R * f9);
                        G = (k1.G * f1 + k2.G * f2 + k3.G * f3 + k4.G * f4 + k5.G * f5 + k6.G * f6 + k7.G * f7 + k8.G * f8 + k9.G * f9);
                        B = (k1.B * f1 + k2.B * f2 + k3.B * f3 + k4.B * f4 + k5.B * f5 + k6.B * f6 + k7.B * f7 + k8.B * f8 + k9.B * f9);
                    }
                    


                    R = sprawdzRGB((int)R);
                    G = sprawdzRGB((int)G);
                    B = sprawdzRGB((int)B);
                    b2.SetPixel(i, j, Color.FromArgb((int)R, (int)G, (int)B));
                }
            }

            pictureBox2.Image = b2;
            pictureBox2.Refresh();
        }
    }
 }

