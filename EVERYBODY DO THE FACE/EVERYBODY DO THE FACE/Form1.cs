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
        private void button1_Click(object sender, EventArgs e)
        {
            
            gfx.FillEllipse(Brushes.Cyan, 200, 100, 50, 50);
            gfx.FillEllipse(Brushes.Cyan, 325, 100, 50, 50);
            gfx.FillEllipse(Brushes.Black, 235, 175, 100, 50);
            gfx.DrawEllipse(Pens.Blue, 165, 25, 250, 250);
            gfx.FillRectangle(new SolidBrush(BackColor), 235, 150, 100, 50); 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            gfx = this.CreateGraphics();
        }
        
    }
}
