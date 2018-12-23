namespace WindowsFormsApplication1
{
    partial class MasterMindWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.TextBox();
            this.debugLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.talkingThing = new System.Windows.Forms.Label();
            this.talkingThing1 = new System.Windows.Forms.Label();
            this.talkingThing2 = new System.Windows.Forms.Label();
            this.talkingThing3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.youWin = new System.Windows.Forms.Label();
            this.iCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(71, 155);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(54, 20);
            this.textBox.TabIndex = 0;
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.Location = new System.Drawing.Point(12, 9);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(35, 13);
            this.debugLabel.TabIndex = 1;
            this.debugLabel.Text = "label1";
            this.debugLabel.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // talkingThing
            // 
            this.talkingThing.AutoSize = true;
            this.talkingThing.Location = new System.Drawing.Point(12, 51);
            this.talkingThing.Name = "talkingThing";
            this.talkingThing.Size = new System.Drawing.Size(0, 13);
            this.talkingThing.TabIndex = 3;
            // 
            // talkingThing1
            // 
            this.talkingThing1.AutoSize = true;
            this.talkingThing1.Location = new System.Drawing.Point(136, 77);
            this.talkingThing1.Name = "talkingThing1";
            this.talkingThing1.Size = new System.Drawing.Size(0, 13);
            this.talkingThing1.TabIndex = 4;
            // 
            // talkingThing2
            // 
            this.talkingThing2.AutoSize = true;
            this.talkingThing2.Location = new System.Drawing.Point(246, 38);
            this.talkingThing2.Name = "talkingThing2";
            this.talkingThing2.Size = new System.Drawing.Size(0, 13);
            this.talkingThing2.TabIndex = 5;
            // 
            // talkingThing3
            // 
            this.talkingThing3.AutoSize = true;
            this.talkingThing3.Location = new System.Drawing.Point(373, 90);
            this.talkingThing3.Name = "talkingThing3";
            this.talkingThing3.Size = new System.Drawing.Size(0, 13);
            this.talkingThing3.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(58, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(262, 154);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(57, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(360, 154);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(54, 20);
            this.textBox3.TabIndex = 9;
            // 
            // youWin
            // 
            this.youWin.AutoSize = true;
            this.youWin.Location = new System.Drawing.Point(238, 319);
            this.youWin.Name = "youWin";
            this.youWin.Size = new System.Drawing.Size(0, 13);
            this.youWin.TabIndex = 10;
            // 
            // iCount
            // 
            this.iCount.AutoSize = true;
            this.iCount.Location = new System.Drawing.Point(608, 339);
            this.iCount.Name = "iCount";
            this.iCount.Size = new System.Drawing.Size(13, 13);
            this.iCount.TabIndex = 11;
            this.iCount.Text = "0";
            // 
            // MasterMindWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 372);
            this.Controls.Add(this.iCount);
            this.Controls.Add(this.youWin);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.talkingThing3);
            this.Controls.Add(this.talkingThing2);
            this.Controls.Add(this.talkingThing1);
            this.Controls.Add(this.talkingThing);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.debugLabel);
            this.Controls.Add(this.textBox);
            this.Name = "MasterMindWindow";
            this.Text = "THE MASTERMIND";
            this.Load += new System.EventHandler(this.MasterMindWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label debugLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label talkingThing;
        private System.Windows.Forms.Label talkingThing1;
        private System.Windows.Forms.Label talkingThing2;
        private System.Windows.Forms.Label talkingThing3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label youWin;
        private System.Windows.Forms.Label iCount;
    }
}

