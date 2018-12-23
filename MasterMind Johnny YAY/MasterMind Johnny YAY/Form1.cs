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
    public partial class MasterMindWindow : Form
    {
        public MasterMindWindow()
        {
            InitializeComponent();
        }

        int[] computerNumber = new int[4];
        int wrongCount = 0;
        private void MasterMindWindow_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            debugLabel.Text = "";

            for (int i = 0; i < computerNumber.Length; i++)
            {
                int temp = -1;
                do
                {
                    temp = random.Next(10);
                }while(computerNumber.Contains(temp));

                computerNumber[i] = temp;
                debugLabel.Text += computerNumber[i];

            }

            

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] userNumbers = new int[4];

            userNumbers[0] = int.Parse(textBox.Text);
            userNumbers[1] = int.Parse(textBox1.Text);
            userNumbers[2] = int.Parse(textBox2.Text);
            userNumbers[3] = int.Parse(textBox3.Text);

            int actualUserNumber = userNumbers[0] * 1000 + userNumbers[1] * 100 + userNumbers[2] * 10 + userNumbers[3];
            int actualCPUNumber = computerNumber[0] * 1000 + userNumbers[1] * 100 + userNumbers[2] * 10 + userNumbers[3];
            if (actualCPUNumber == actualUserNumber)
            {
                youWin.Text = "YOU WIN!";
            }
            else
            {
                wrongCount++;
                iCount.Text = wrongCount.ToString();
            }
            //create an actualCPUNumber

            //check if the usernum and cpu match, if they do then display a messagebox, if not then add one to the wrongcount

                if (userNumbers[0] == computerNumber[0])
                {
                    talkingThing.Text = "The first number is correct";
                }
                if (userNumbers[1] == computerNumber[1])
                {
                    talkingThing1.Text = "The second number is correct";
                }
                if (userNumbers[2] == computerNumber[2])
                {
                    talkingThing2.Text = "The third number is correct";
                }
                if (userNumbers[3] == computerNumber[3])
                {
                    talkingThing3.Text = "The fourth number is correct";
                }
                if (userNumbers[0] != computerNumber[0])
                {
                    talkingThing.Text = "The first number is incorrect";
                    if (computerNumber.Contains(userNumbers[0]))
                    {
                        talkingThing.Text = "The first number is in the wrong spot";
                    }
                }
                if (userNumbers[1] != computerNumber[1])
                {
                    talkingThing1.Text = "The second number is incorrect";
                    if (computerNumber.Contains(userNumbers[1]))
                    {
                        talkingThing1.Text = "The second number is in the wrong spot";
                    }
                }
                if (userNumbers[2] != computerNumber[2])
                {
                    talkingThing2.Text = "The third number is incorrect";
                    if (computerNumber.Contains(userNumbers[2]))
                    {
                        talkingThing2.Text = "The third number is in the wrong spot";
                    }
                }
                if (userNumbers[3] != computerNumber[3])
                {
                    talkingThing3.Text = "The fourth number is incorrect";
                    if (computerNumber.Contains(userNumbers[3]))
                    {
                        talkingThing3.Text = "The fourth number is in the wrong spot";
                    }
                }
            

        }
    }
}
