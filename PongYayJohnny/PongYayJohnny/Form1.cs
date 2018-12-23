using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics gfx;
        Bitmap map;
        int paddleSpeed = 6;

        int playerScore = 0;
        int computerScore = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            map = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gfx = Graphics.FromImage(map);
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                Paddle1.Erase(gfx);

                Paddle1._y -= paddleSpeed;

                Paddle1.Draw(gfx);
            }
            if (e.KeyCode == Keys.S)
            {
                Paddle1.Erase(gfx);

                Paddle1._y += paddleSpeed;

                Paddle1.Draw(gfx);
            }
        }
        
        
        

        Paddle Paddle1 = new Paddle();
        Paddle Paddle2 = new Paddle();
        Circle circle1 = new Circle();
        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            startButton.Visible = false;
            
            circle1.Load(260, 175, 50, 2, 2, Color.Black, this.BackColor);
            Paddle1.Load(25, 175, 20, 100, Color.Black, this.BackColor);
            Paddle2.Load(525, 175, 20, 100, Color.Black, this.BackColor);
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            circle1.Erase(gfx);
            Paddle1.Erase(gfx);
            Paddle2.Erase(gfx);
            circle1._y += circle1._yspeed;
            circle1._x += circle1._xspeed;

            Paddle2._y = circle1._y;

            circle1.Update();
            Paddle1.Update();
            Paddle2.Update();
            
            
            //explain to abe what this means...
            if (Paddle1._boundingBox.IntersectsWith(circle1._boundingBox))
            {
                circle1._xspeed *= -1;
            }
            if (Paddle2._boundingBox.IntersectsWith(circle1._boundingBox))
            {
                circle1._xspeed *= -1;
            }
            //if (circle1._x + circle1._diameter > ClientSize.Width || circle1._x < 0)
            //{
            //    circle1._xspeed *= -1;
            //}
            if (circle1._y + circle1._diameter > ClientSize.Height || circle1._y < 0)
            {
                circle1._yspeed *= -1;
            }
            circle1.Draw(gfx);
            Paddle1.Draw(gfx);
            Paddle2.Draw(gfx);
            
            
            if (circle1._x + circle1._diameter > ClientSize.Width || circle1._x < 0)
            {
                circle1.Erase(gfx);
                
                if (circle1._x < 0)
                {
                    computerScore++;
                    score2.Text = computerScore.ToString();
                    playerScore = 0;
                    circle1._x = 260;
                    circle1._y = 175;
                    score1.Text = playerScore.ToString();
                }

            }

            pictureBox1.Image = map;
            
        }

    }
}
