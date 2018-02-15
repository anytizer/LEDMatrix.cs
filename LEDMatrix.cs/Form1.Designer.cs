namespace LEDMatrix.cs
{
    partial class Form1
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
            this.LEDs8 = new LEDMatrix.cs.LEDs();
            this.LEDs7 = new LEDMatrix.cs.LEDs();
            this.LEDs6 = new LEDMatrix.cs.LEDs();
            this.LEDs5 = new LEDMatrix.cs.LEDs();
            this.LEDs4 = new LEDMatrix.cs.LEDs();
            this.LEDs3 = new LEDMatrix.cs.LEDs();
            this.LEDs2 = new LEDMatrix.cs.LEDs();
            this.LEDs1 = new LEDMatrix.cs.LEDs();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.allONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allOFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LEDs8
            // 
            this.LEDs8.Location = new System.Drawing.Point(7, 239);
            this.LEDs8.Name = "LEDs8";
            this.LEDs8.Size = new System.Drawing.Size(320, 30);
            this.LEDs8.TabIndex = 8;
            // 
            // LEDs7
            // 
            this.LEDs7.Location = new System.Drawing.Point(7, 208);
            this.LEDs7.Name = "LEDs7";
            this.LEDs7.Size = new System.Drawing.Size(320, 30);
            this.LEDs7.TabIndex = 7;
            // 
            // LEDs6
            // 
            this.LEDs6.Location = new System.Drawing.Point(7, 179);
            this.LEDs6.Name = "LEDs6";
            this.LEDs6.Size = new System.Drawing.Size(320, 30);
            this.LEDs6.TabIndex = 6;
            // 
            // LEDs5
            // 
            this.LEDs5.Location = new System.Drawing.Point(7, 150);
            this.LEDs5.Name = "LEDs5";
            this.LEDs5.Size = new System.Drawing.Size(320, 30);
            this.LEDs5.TabIndex = 5;
            // 
            // LEDs4
            // 
            this.LEDs4.Location = new System.Drawing.Point(7, 119);
            this.LEDs4.Name = "LEDs4";
            this.LEDs4.Size = new System.Drawing.Size(320, 30);
            this.LEDs4.TabIndex = 4;
            // 
            // LEDs3
            // 
            this.LEDs3.Location = new System.Drawing.Point(7, 89);
            this.LEDs3.Name = "LEDs3";
            this.LEDs3.Size = new System.Drawing.Size(320, 30);
            this.LEDs3.TabIndex = 3;
            // 
            // LEDs2
            // 
            this.LEDs2.Location = new System.Drawing.Point(7, 58);
            this.LEDs2.Name = "LEDs2";
            this.LEDs2.Size = new System.Drawing.Size(320, 30);
            this.LEDs2.TabIndex = 2;
            // 
            // LEDs1
            // 
            this.LEDs1.Location = new System.Drawing.Point(7, 27);
            this.LEDs1.Name = "LEDs1";
            this.LEDs1.Size = new System.Drawing.Size(320, 30);
            this.LEDs1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allONToolStripMenuItem,
            this.allOFFToolStripMenuItem,
            this.copyDataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(339, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // allONToolStripMenuItem
            // 
            this.allONToolStripMenuItem.Name = "allONToolStripMenuItem";
            this.allONToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.allONToolStripMenuItem.Text = "All ON";
            // 
            // allOFFToolStripMenuItem
            // 
            this.allOFFToolStripMenuItem.Name = "allOFFToolStripMenuItem";
            this.allOFFToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.allOFFToolStripMenuItem.Text = "All OFF";
            // 
            // copyDataToolStripMenuItem
            // 
            this.copyDataToolStripMenuItem.Name = "copyDataToolStripMenuItem";
            this.copyDataToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.copyDataToolStripMenuItem.Text = "Copy Data";
            this.copyDataToolStripMenuItem.Click += new System.EventHandler(this.copyDataToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 275);
            this.Controls.Add(this.LEDs8);
            this.Controls.Add(this.LEDs7);
            this.Controls.Add(this.LEDs6);
            this.Controls.Add(this.LEDs5);
            this.Controls.Add(this.LEDs4);
            this.Controls.Add(this.LEDs3);
            this.Controls.Add(this.LEDs2);
            this.Controls.Add(this.LEDs1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LED Matrix";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LEDs LEDs1;
        private LEDs LEDs2;
        private LEDs LEDs3;
        private LEDs LEDs4;
        private LEDs LEDs5;
        private LEDs LEDs6;
        private LEDs LEDs7;
        private LEDs LEDs8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem allONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allOFFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyDataToolStripMenuItem;
    }
}

