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
            if (button2.Location.X < 10 && button2.Location.X > 0)
                button2.Location = new Point(0, button2.Location.Y);
            else
                button2.Location = new Point(button2.Location.X-10 > 0 ? button2.Location.X - 10 : ClientRectangle.Width - button2.Width, button2.Location.Y);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int offset = 10;
            if (ClientRectangle.Width - (button2.Location.X + button2.Width) < 10)
                offset = ClientRectangle.Width - (button2.Location.X + button2.Width);
            button2.Location = new Point(button2.Location.X >= ClientRectangle.Width - button2.Width ? button2.Left : button2.Location.X + offset, button2.Location.Y);
        }
    }
}
