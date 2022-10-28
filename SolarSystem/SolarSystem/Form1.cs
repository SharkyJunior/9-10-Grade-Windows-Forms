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

        List<Astro> bodies;
        Sun sun;
        Saturn saturn;
        MoonScythe moonScythe;
        
        public Form1()
        {
            InitializeComponent();
            bodies = new List<Astro>();
            bodies.Add(new Sun(random.Next(100, 300), random.Next(100, 300), 200));
            bodies.Add(new Saturn(random.Next(300, 500), random.Next(200, 400), 150));
            bodies.Add(new MoonScythe(random.Next(500, 700), random.Next(300, 500), 100));
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        { 
            using (Graphics g = e.Graphics)
            {
                this.BackColor = Color.Navy;
                foreach (var body in bodies)
                    body.Draw(g);
            }
        }

        private void sunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sunToolStripMenuItem.Checked = !sunToolStripMenuItem.Checked;
            bodies[0].IsShown = sunToolStripMenuItem.Checked;
            Refresh();
        }

        private void saturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saturnToolStripMenuItem.Checked = !saturnToolStripMenuItem.Checked;
            bodies[1].IsShown = saturnToolStripMenuItem.Checked;
            Refresh();
        }

        private void moonScytheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moonScytheToolStripMenuItem.Checked = !moonScytheToolStripMenuItem.Checked;
            bodies[2].IsShown = moonScytheToolStripMenuItem.Checked;
            Refresh();
        }

        private void newBodiesPositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bodies[0] = new Sun(random.Next(100, 300), random.Next(100, 300), 200);
            bodies[0].IsShown = sunToolStripMenuItem.Checked;
            bodies[1] = new Saturn(random.Next(300, 500), random.Next(300, 500), 150);
            bodies[1].IsShown = saturnToolStripMenuItem.Checked;
            bodies[2] = new MoonScythe(random.Next(300, 500), random.Next(300, 500), 100);
            bodies[2].IsShown = moonScytheToolStripMenuItem.Checked;
            Refresh();
        }
    }
}
