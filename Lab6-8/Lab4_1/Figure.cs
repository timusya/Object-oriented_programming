using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab4_1
{
    public abstract class Figure : CObject, CObserver
    {
        public abstract void SetCondition(int condition);
        public abstract int GetCondition();
        public abstract bool Check(MouseEventArgs e);
        public abstract void Draw(Graphics g);
        public abstract void Move(int dx, int dy, int dr, PictureBox p);
        public abstract void SetColor(Color color);
        public abstract void Save(string path);
        public abstract void Load(StreamReader sr);

        public abstract int GetX();
        public abstract int GetY();

        public Color GetColor(string str)
        {
            str = str.Remove(0, 7);
            str = str.Remove(str.Length - 1, 1);
            var res = new Regex("[0-9]+").Matches(str);
            if (res.Count() == 0)
                return Color.FromName(str);
            else
                return Color.FromArgb(int.Parse(res[0].ToString()), int.Parse(res[1].ToString()),
                                      int.Parse(res[2].ToString()), int.Parse(res[3].ToString()));
        }

        public void UpdateMove(int dx, int dy, int dr, PictureBox p)
        {
            //MessageBox.Show("in UpdateMove");
            // TO DO something
            Move(dx, dy, dr, p);
        }

        public void BuildTree()
        {

        }


    }
}
