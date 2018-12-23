namespace WindowsFormsApplication1
{
    partial class WinForms1
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
            this.dancingButton = new System.Windows.Forms.Button();
            this.ChangingMessage = new System.Windows.Forms.Label();
            this.invisButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dancingButton
            // 
            this.dancingButton.Location = new System.Drawing.Point(243, 170);
            this.dancingButton.Name = "dancingButton";
            this.dancingButton.Size = new System.Drawing.Size(75, 23);
            this.dancingButton.TabIndex = 0;
            this.dancingButton.Text = "CLICKME";
            this.dancingButton.UseVisualStyleBackColor = true;
            this.dancingButton.Click += new System.EventHandler(this.dancingButton_Click);
            this.dancingButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dancingButton_MouseMove);
            // 
            // ChangingMessage
            // 
            this.ChangingMessage.AutoSize = true;
            this.ChangingMessage.Location = new System.Drawing.Point(243, 67);
            this.ChangingMessage.Name = "ChangingMessage";
            this.ChangingMessage.Size = new System.Drawing.Size(0, 13);
            this.ChangingMessage.TabIndex = 1;
            // 
            // invisButton
            // 
            this.invisButton.Location = new System.Drawing.Point(1156, 558);
            this.invisButton.Name = "invisButton";
            this.invisButton.Size = new System.Drawing.Size(75, 23);
            this.invisButton.TabIndex = 2;
            this.invisButton.Text = "BUTTON";
            this.invisButton.UseVisualStyleBackColor = true;
            this.invisButton.Click += new System.EventHandler(this.invisButton_Click);
            // 
            // WinForms1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 439);
            this.Controls.Add(this.invisButton);
            this.Controls.Add(this.ChangingMessage);
            this.Controls.Add(this.dancingButton);
            this.Name = "WinForms1";
            this.Text = "first windows form";
            this.Load += new System.EventHandler(this.WinForms1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    
        

    


        #endregion

        private System.Windows.Forms.Button dancingButton;
        private System.Windows.Forms.Label ChangingMessage;
        private System.Windows.Forms.Button invisButton;

    }
}

