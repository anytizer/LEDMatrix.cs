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

            updateBinaryValues();

        }

        internal void all(bool status)
        {
            Color color = status ? on : off;
            button1.BackColor = color;
            button2.BackColor = color;
            button3.BackColor = color;
            button4.BackColor = color;
            button5.BackColor = color;
            button6.BackColor = color;
            button7.BackColor = color;
            button8.BackColor = color;
        }

        internal void invert()
        {
            change(button1);
            change(button2);
            change(button3);
            change(button4);
            change(button5);
            change(button6);
            change(button7);
            change(button8);
        }

        private void updateBinaryValues()
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
            all(false);
        }
    }
}
