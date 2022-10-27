using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolarSystem
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        static Sun sun;
        static Saturn saturn;
        static Mars mars;
        
        public Form1()
        {
            InitializeComponent();
            sun = new Sun(random.Next(100, 300), random.Next(100, 300), 200);
            saturn = new Saturn(random.Next(300, 500), random.Next(300, 500), 150);
            mars = new Mars(random.Next(300, 500), random.Next(100, 300), 100);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        { 
            using (Graphics g = e.Graphics)
            {
                this.BackColor = Color.Navy;
                if (sunToolStripMenuItem.Checked)
                    sun.Draw(g);
                if (saturnToolStripMenuItem.Checked)
                    saturn.Draw(g);
                if (marsToolStripMenuItem.Checked)
                    mars.Draw(g);
            }
        }

        private void sunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sunToolStripMenuItem.Checked = !sunToolStripMenuItem.Checked;
            Refresh();
        }

        private void saturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saturnToolStripMenuItem.Checked = !saturnToolStripMenuItem.Checked;
            Refresh();
        }

        private void marsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            marsToolStripMenuItem.Checked = !marsToolStripMenuItem.Checked;
            Refresh();
        }
    }
}
