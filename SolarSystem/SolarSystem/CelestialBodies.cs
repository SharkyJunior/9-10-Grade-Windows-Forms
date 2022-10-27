using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem
{
    abstract class Astro
    {
        protected int size, x, y;

        public Astro(int x, int y, int size)
        {
            this.x = x;
            this.y = y;
            this.size = size;
        }

        abstract public void Draw(Graphics g);
    }

    sealed class Sun : Astro
    {
        public Sun(int x, int y, int size) : base(x, y, size) {}

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(new Pen(Brushes.Gold), x, y, size, size);
            g.FillEllipse(Brushes.Yellow, x, y, size, size);
        }
    }

    sealed class Saturn : Astro
    {
        public Saturn(int x, int y, int size) : base(x, y, size) { }

        public override void Draw(Graphics g)
        {
            g.DrawArc(new Pen(Brushes.DimGray, 10), x - size / 4, y + size / 4, size + size / 2, size / 2, 180, 360);
            g.FillEllipse(Brushes.Peru, x, y, size, size);
            g.DrawArc(new Pen(Brushes.DimGray, 10), x - size / 4, y + size / 4, size + size / 2, size / 2, 0, 180);
        }
    }

    sealed class Mars : Astro
    {
        public Mars(int x, int y, int size) : base(x, y, size) { }

        public override void Draw(Graphics g)
        {
            g.FillEllipse(Brushes.Tomato, x, y, size, size);
        }
    }
}
