using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    class Triangle : Figure
    {
        private float x, y;
        private float radius;
        private int condition;
        private PointF[] pts = new PointF[3]; 
        private Pen pen = new Pen(Color.Red, 4);
        private SolidBrush sbrush;

        public Triangle(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
            pts[0] = new PointF(x, y - radius);
            pts[1] = new PointF(x - radius * MathF.Sqrt(3) / 2, y + radius / 2);
            pts[2] = new PointF(x + radius * MathF.Sqrt(3) / 2, y + radius / 2);
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
            float m1 = (pts[0].X - e.X) * (pts[1].Y - pts[0].Y) - (pts[0].Y - e.Y) * (pts[1].X - pts[0].X);
            float m2 = (pts[1].X - e.X) * (pts[2].Y - pts[1].Y) - (pts[1].Y - e.Y) * (pts[2].X - pts[1].X);
            float m3 = (pts[2].X - e.X) * (pts[0].Y - pts[2].Y) - (pts[2].Y - e.Y) * (pts[0].X - pts[2].X);
            return (m1 >= 0 && m2 >= 0 && m3 >= 0) || (m1 <= 0 && m2 <= 0 && m3 <= 0);
        }

        public override void Draw(Graphics g)
        {
            pen.Color = condition > 0 ? Color.Blue : Color.Red;
            g.DrawPolygon(pen, pts);
            if (sbrush != null) g.FillPolygon(sbrush, pts);
        }
        
        public override void Move(int dx, int dy, int dr, PictureBox p)
        {
            radius += dr;
            if (radius < 0) radius = 0;
            if (radius * MathF.Sqrt(3) > p.Size.Width) radius = p.Size.Width / MathF.Sqrt(3);
            if (radius * 3 / 2 > p.Size.Height) radius = p.Size.Height * 2 / 3;

            x += dx;
            y += dy;
            if (y < radius) y = radius;
            if (x < radius * MathF.Sqrt(3) / 2) x = radius * MathF.Sqrt(3) / 2;
            if (y > p.Size.Height - radius / 2) y = p.Size.Height - radius / 2;
            if (x > p.Size.Width - radius * MathF.Sqrt(3) / 2) x = p.Size.Width - radius * MathF.Sqrt(3) / 2;

            pts[0] = new PointF(x, y - radius);
            pts[1] = new PointF(x - radius * MathF.Sqrt(3) / 2, y + radius / 2);
            pts[2] = new PointF(x + radius * MathF.Sqrt(3) / 2, y + radius / 2);
        }

        public override void SetColor(Color color)
        {
            sbrush = new SolidBrush(color);
        }
    }
}
