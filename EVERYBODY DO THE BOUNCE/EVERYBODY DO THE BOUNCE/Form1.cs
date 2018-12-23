using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bouncing_Circle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics gfx;
        Random random = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            gfx = this.CreateGraphics();
        }
        //int x2 = 425;
        //int y2 = 150;
        //int width2 = 100;
        //int height2 = 100;
        //int x1 = 150;
        //int y1 = 150;
        //int width1 = 100;
        //int height1 = 100;
        //int xspeed2 = 10;
        //int yspeed2 = 10;
        //int xspeed1 = 10;
        //int yspeed1 = 10;
        //int xspeed = 10;
        //int yspeed = 10;
        //int x = 280;
        //int y = 150;
        //int height = 100;
        //int width = 100;

        Circle circle1;
        Circle circle2;
        //int speed = 10;
        Circle[] circles;
        private void button1_Click(object sender, EventArgs e)
        {
            circles = new Circle[10];


            for (int i = 0; i < circles.Length; i++)
            {
                circles[i] = new Circle();
                circles[i].Load(random.Next(100), random.Next(200), random.Next(50), random.Next(10), random.Next(10), Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)), this.BackColor);

            }


            //circle1.Load(280, 150, 100, 10, 10, Color.Blue, this.BackColor);
            //circle2.Load(425, 150, 100, 10, 10, Color.Aqua, this.BackColor);
            
            button1.Visible = false;
            //gfx.FillEllipse(Brushes.Aqua, x1, y1, width1, height1);
            //gfx.FillEllipse(Brushes.Blue, x, y, width, height);
            //gfx.FillEllipse(Brushes.DarkCyan, x2, y2, width2, height2);
            timer1.Enabled = true;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < circles.Length; i++)
            {
                circles[i].Erase(gfx);
                circles[i]._y += circles[i]._yspeed;
                circles[i]._x += circles[i]._xspeed;
                circles[i].Draw(gfx);
                if (circles[i]._x + circles[i]._diameter > ClientSize.Width || circles[i]._x < 0)
                {
                    circles[i]._xspeed *= -1;
                }
                if (circles[i]._y + circles[i]._diameter > ClientSize.Height || circles[i]._y < 0)
                {
                    circles[i]._yspeed *= -1;
                }

            }
            //gfx.FillEllipse(new SolidBrush(BackColor), circle1._x, circle1._y, circle1._diameter, circle1._diameter);
            //circle1.Erase(gfx);
            //gfx.FillEllipse(new SolidBrush(BackColor), x1, y1, width1, height1);
            //gfx.FillEllipse(new SolidBrush(BackColor), x, y, width, height);
            //gfx.FillEllipse(new SolidBrush(BackColor), x2, y2, width2, height2);
            //y1 += yspeed1;
            //x1 += xspeed1;
            //circle1._y += circle1._yspeed;
            //circle1._x += circle1._xspeed;
            //y2 += yspeed2;
            //x2 += xspeed2;
            //circle1.Draw(gfx);
            //gfx.FillEllipse(Brushes.Aqua, x1, y1, width1, height1);
            //gfx.FillEllipse(Brushes.DarkCyan, x2, y2, width2, height2);
            //if (circle1._x + circle1._diameter > ClientSize.Width || circle1._x < 0)
            //{
            //    circle1._xspeed *= -1;
            //}
            //if (circle1._y + circle1._diameter > ClientSize.Height || circle1._y < 0)
            //{
            //    circle1._yspeed *= -1;
            //}
            //if (x1 + width1 > ClientSize.Width || x1 < 0)
            //{
            //    xspeed1 *= -1;
            //}
            //if (y1 + height1 > ClientSize.Height || y1 < 0)
            //{
            //    yspeed1 *= -1;
            //}
            //if (y2 + height2 > ClientSize.Height || y2 < 0)
            //{
            //    yspeed2 *= -1;
            //}
            //if (x2 + width2 > ClientSize.Width || x2 < 0)
            //{
            //    xspeed2 *= -1;
            //}
        }
    }
}
