using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NegativeImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //read image
            Bitmap bmp = new Bitmap("D:\\Image\\Taj.jpg");

            //load image in picturebox1
            pictureBox1.Image = Image.FromFile("D:\\Image\\Taj.jpg");

            //get image dimension
            int width = bmp.Width;
            int height = bmp.Height;

            //negative
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //get pixel value
                    Color p = bmp.GetPixel(x, y);

                    //extract ARGB value from p
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    //find negative value
                    r = 255 - r;
                    g = 255 - g;
                    b = 255 - b;

                    //set new ARGB value in pixel
                    bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }

            //load negative image in picturebox2
            pictureBox2.Image = bmp;

            //save negative image
            bmp.Save("D:\\Image\\Negative.png");
        }
    }
}
