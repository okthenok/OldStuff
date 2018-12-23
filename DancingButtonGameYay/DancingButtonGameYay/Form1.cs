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
    public partial class WinForms1 : Form
    {
        public WinForms1()
        {
            InitializeComponent();
        }
        Random rand = new Random();
        private void WinForms1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("THE DANCING BUTTON GAME");
            MessageBox.Show("Instructions:");
            MessageBox.Show("Click the BUTTON");
        }

        void dancingButton_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            int locationx = rand.Next(0,300);
            int locationy = rand.Next(0,300);
            dancingButton.Location = new Point(locationx, locationy);
        }

        private void dancingButton_Click(object sender, EventArgs e)
        {
            ChangingMessage.Text = ("WRONG BUTTON");
        }

        private void invisButton_Click(object sender, EventArgs e)
        {
            ChangingMessage.Text = ("Good Job! You Win!");
        }
      
    }
}
