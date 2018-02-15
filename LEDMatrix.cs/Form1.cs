using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEDMatrix.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /**
         * Copy matrix assignment into clipboard memory
         */
        private void copyDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string data = @"
int j = 0;
int data[8];
";
            string prefix = "data[++j]=\"";
            string postfix = "\";";
            data += "\r\n" + prefix + LEDs1.value() + postfix;
            data += "\r\n" + prefix + LEDs2.value() + postfix;
            data += "\r\n" + prefix + LEDs3.value() + postfix;
            data += "\r\n" + prefix + LEDs4.value() + postfix;
            data += "\r\n" + prefix + LEDs5.value() + postfix;
            data += "\r\n" + prefix + LEDs6.value() + postfix;
            data += "\r\n" + prefix + LEDs7.value() + postfix;
            data += "\r\n" + prefix + LEDs8.value() + postfix;

            Clipboard.SetText(data);
        }

        private void allONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LEDs1.all(true);
            LEDs2.all(true);
            LEDs3.all(true);
            LEDs4.all(true);
            LEDs5.all(true);
            LEDs6.all(true);
            LEDs7.all(true);
            LEDs8.all(true);
        }

        private void allOFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LEDs1.all(false);
            LEDs2.all(false);
            LEDs3.all(false);
            LEDs4.all(false);
            LEDs5.all(false);
            LEDs6.all(false);
            LEDs7.all(false);
            LEDs8.all(false);
        }

        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LEDs1.invert();
            LEDs2.invert();
            LEDs3.invert();
            LEDs4.invert();
            LEDs5.invert();
            LEDs6.invert();
            LEDs7.invert();
            LEDs8.invert();
        }
    }
}
