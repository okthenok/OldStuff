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
        Block food1;
        SnakeBlock snakeBlock1;
        Graphics gfx;
        Random rand;
        Snake mySnake;
        SnakeBlock lastPiece;
        SnakeBlock newPiece;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            mySnake = new Snake();
            mySnake.SnakeList = new List<SnakeBlock>();
            rand = new Random();
            gfx = this.CreateGraphics();
            snakeBlock1 = new SnakeBlock();
            snakeBlock1.Load(400, 300, 12, Color.Black, this.BackColor);


            mySnake.SnakeList.Add(snakeBlock1);

            food1 = new Block();
            
            food1.Load(200, 120, 12, Color.Green, this.BackColor);
            
        }
        
        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Visible = false;

            this.KeyPreview = true;
            timer1.Enabled = true;
            food1.Draw(gfx);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            snakeBlock1.Update();
            food1.Update();

            mySnake.Erase(gfx);
            mySnake.Update(gfx);
            for (int i = mySnake.SnakeList.Count - 1; i > 0; i--)
            {
                mySnake.SnakeList[i].Direction = mySnake.SnakeList[i - 1].Direction; 
            }
       
            mySnake.Draw(gfx);

            if (snakeBlock1.BoundingBox.IntersectsWith(food1.BoundingBox))
            {
                food1.Erase(gfx);
                food1.X = rand.Next(0, ClientSize.Width - food1.Diameter);
                food1.Y = rand.Next(0, ClientSize.Height - food1.Diameter);
                lastPiece = mySnake.SnakeList[mySnake.SnakeList.Count - 1];
                newPiece = new SnakeBlock();
                //0 = up, 1 = left, 2 = down, 3 = right
                if (lastPiece.Direction == 0) //UP
                {
                    newPiece.Load(lastPiece.X, lastPiece.Y + lastPiece.Diameter + 1, lastPiece.Diameter, Color.Blue, this.BackColor);
                }
                else if (lastPiece.Direction == 1) //LEFT
                {
                    newPiece.Load(lastPiece.X + lastPiece.Diameter + 1, lastPiece.Y, lastPiece.Diameter, Color.Blue, this.BackColor);
                }
                else if (lastPiece.Direction == 2) //DOWN
                {
                    newPiece.Load(lastPiece.X, lastPiece.Y - lastPiece.Diameter - 1, lastPiece.Diameter, Color.Blue, this.BackColor);
                }
                else if (lastPiece.Direction == 3) //RIGHT
                {
                    newPiece.Load(lastPiece.X - lastPiece.Diameter - 1, lastPiece.Y, lastPiece.Diameter, Color.Blue, this.BackColor);
                }
               

                newPiece.Direction = lastPiece.Direction;
                mySnake.SnakeList.Add(newPiece);

            }
            


            if (snakeBlock1.X > ClientSize.Width || snakeBlock1.X + snakeBlock1.Diameter < 0 || snakeBlock1.Y + snakeBlock1.Diameter < 0 || snakeBlock1.Y > ClientSize.Height)
            {
                //stupid me i forgot how to do dis
                //u lose teehee
                snakeBlock1.Erase(gfx);
                timer1.Enabled = false;
                MessageBox.Show("You lose");
                snakeBlock1.X = 400;
                snakeBlock1.Y = 300;
                snakeBlock1.Direction = 0;
                startButton.Visible = true;
                mySnake.SnakeList.Clear();
                mySnake.SnakeList.Add(snakeBlock1);
                this.Refresh();
                //add gamestates(put a start comma lose introduction of the lakhro;aiwhjtroiajidoawierht_(*&KJEHE%**(Yjhlkau4tyiu**(*%#_)*$(@*_+LKDJF:L:)))
            }

            food1.Draw(gfx);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //You can not turn the opposite way of where you are going
            if (e.KeyCode == Keys.Down && snakeBlock1.Direction != 0)
            {
               snakeBlock1.Direction = 2;
            }
            if (e.KeyCode == Keys.Up && snakeBlock1.Direction != 2)
            {
                snakeBlock1.Direction = 0;
            }
            if (e.KeyCode == Keys.Left && snakeBlock1.Direction != 3)
            {
                snakeBlock1.Direction = 1;
            }
            if (e.KeyCode == Keys.Right && snakeBlock1.Direction != 1)
            {
                snakeBlock1.Direction = 3;
            }
            
        }
    }
}
//what shall we do
//PLS WHAT SHALL WE DO
//CMON
//TELL ME
//U BETTER TELL ME OR ELSE
//SOMEONE HELPZ
//????????????
//hotshotgg sucks
//c9 should win
//someone help

//Ezra is not diamond
//aria is not diamond

//add snake blocks by eating blocks
//