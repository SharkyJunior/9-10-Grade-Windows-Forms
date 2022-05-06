using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buttons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Location = new Point(button2.Location.X-10 >= 0 ? button2.Location.X - 10 : this.Width - button2.Width, button2.Location.Y);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Location = new Point(button2.Location.X + 10 <= this.Width - button2.Width ? button2.Location.X + 10 : button2.Location.X, button2.Location.Y);
        }
    }
}
