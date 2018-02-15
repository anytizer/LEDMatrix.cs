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
    }
}
