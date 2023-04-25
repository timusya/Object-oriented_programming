using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    public class CCircle
    {
        private int x, y;
        private int radius;
        private int condition;
        private Rectangle rect;
        private Pen pen = new Pen(Color.Red, 3);

        public CCircle(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
            rect = new Rectangle(x - radius, y - radius, 2 * radius, 2 * radius);
        }

        public void SetCondition(int condition)
        {
            this.condition = condition;
        }

        public int GetCondition()
        {
            return condition;
        }
        public bool Check(MouseEventArgs e)
        {
            return (Math.Pow(x - e.X, 2) +  Math.Pow(y - e.Y, 2) <= Math.Pow(radius, 2));
        }

        public void Draw(Graphics g)
        {
            pen.Color = condition > 0 ? Color.Green : Color.Red;
            g.DrawEllipse(pen, rect);
        }
    }
}
