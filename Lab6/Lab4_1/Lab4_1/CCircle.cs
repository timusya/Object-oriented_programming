using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    class CCircle : Figure
    {
        private int x, y;
        private int radius;
        private int condition;
        private Rectangle rect;
        private Pen pen = new Pen(Color.Red, 4);
        private SolidBrush sbrush;

        public CCircle(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public override void SetCondition(int condition)
        {
            this.condition = condition;
        }
        
        public override int GetCondition()
        {
            return condition;
        }
        public override bool Check(MouseEventArgs e)
        {
            return (Math.Pow(x - e.X, 2) +  Math.Pow(y - e.Y, 2) <= Math.Pow(radius, 2));
        }

        public override void Draw(Graphics g)
        {
            pen.Color = condition > 0 ? Color.Blue : Color.Red;
            rect = new Rectangle(x - radius, y - radius, 2 * radius, 2 * radius);
            g.DrawEllipse(pen, rect);
            if (sbrush != null) g.FillEllipse(sbrush, rect);
        }

        public override void Move(int dx, int dy, int dr, PictureBox p)
        {
            radius += dr;
            if (radius < 0) radius = 0;
            if (2 * radius > Math.Min(p.Size.Width, p.Size.Height))
                radius = Math.Min(p.Size.Width, p.Size.Height) / 2;

            x += dx;
            y += dy;
            if (x - radius < 0) x = radius;
            if (y - radius < 0) y = radius;
            if (x + radius > p.Size.Width) x = p.Size.Width - radius;
            if (y + radius > p.Size.Height) y = p.Size.Height - radius;
        }

        public override void SetColor(Color color)
        {
            sbrush = new SolidBrush(color);
        }
    }
}
