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
        static MoonScythe moonScythe;
        
        public Form1()
        {
            InitializeComponent();
            sun = new Sun(random.Next(100, 300), random.Next(100, 300), 200);
            saturn = new Saturn(random.Next(300, 500), random.Next(300, 500), 150);
            moonScythe = new MoonScythe(random.Next(300, 500), random.Next(300, 500), 100);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        { 
            using (Graphics g = e.Graphics)
            {
                this.BackColor = Color.Navy;
                if (moonScytheToolStripMenuItem.Checked)
                    moonScythe.Draw(g);
                if (sunToolStripMenuItem.Checked)
                    sun.Draw(g);
                if (saturnToolStripMenuItem.Checked)
                    saturn.Draw(g);
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

        private void moonScytheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moonScytheToolStripMenuItem.Checked = !moonScytheToolStripMenuItem.Checked;
            Refresh();
        }

        private void newBodiesPositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sun = new Sun(random.Next(100, 300), random.Next(100, 300), 200);
            saturn = new Saturn(random.Next(300, 500), random.Next(300, 500), 150);
            moonScythe = new MoonScythe(random.Next(300, 500), random.Next(300, 500), 100);
            Refresh();
        }
    }
}
