using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEDMatrix.cs
{
    public partial class LEDs : UserControl
    {
        private Color on = Color.Red;
        private Color off = Color.LightGray;
        public LEDs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            change(sender as Button);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            change(sender as Button);
        }

        internal string value()
        {
            return label1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            change(sender as Button);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            change(sender as Button);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            change(sender as Button);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            change(sender as Button);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            change(sender as Button);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            change(sender as Button);
        }

        private void change(Button b)
        {
            if (b.BackColor != on)
                b.BackColor = on;
            else
                b.BackColor = off;

            updateValues();

        }

        private void updateValues()
        {
            label1.Text = string.Format("0b{0}{1}{2}{3}{4}{5}{6}{7}",
                LEDValue(button1),
                LEDValue(button2),
                LEDValue(button3),
                LEDValue(button4),
                LEDValue(button5),
                LEDValue(button6),
                LEDValue(button7),
                LEDValue(button8)
                );
        }

        private string LEDValue(Button b)
        {
            if (b.BackColor == on)
                return "1";
            else
                return "0";
        }

        private void LEDs_Load(object sender, EventArgs e)
        {
            button1.BackColor = off;
            button2.BackColor = off;
            button3.BackColor = off;
            button4.BackColor = off;
            button5.BackColor = off;
            button6.BackColor = off;
            button7.BackColor = off;
            button8.BackColor = off;
        }
    }
}
