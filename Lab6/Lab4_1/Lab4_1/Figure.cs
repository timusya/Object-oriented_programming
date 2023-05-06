using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    public abstract class Figure
    {
        public abstract void SetCondition(int condition);
        public abstract int GetCondition();
        public abstract bool Check(MouseEventArgs e);
        public abstract void Draw(Graphics g);
        public abstract void Move(int dx, int dy, int dr, PictureBox p);
        public abstract void SetColor(Color color);
    }
}
