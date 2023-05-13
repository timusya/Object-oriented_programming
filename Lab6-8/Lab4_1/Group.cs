using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    class Group : Figure
    {
        private List<Figure> fs;

        public Group()
        {
            fs = new List<Figure>();
        }

        public void AddFigure(Figure f)
        {
            fs.Add(f);
        }

        public override void SetCondition(int condition)
        {
            foreach (var f in fs)
                f.SetCondition(condition);
        }

        public override int GetCondition()
        {
            return fs[0].GetCondition();
        }
        public override bool Check(MouseEventArgs e)
        {
            bool ret = false;
            foreach (var f in fs)
                ret |= f.Check(e);
            return ret;
        }

        public override void Draw(Graphics g)
        {
            foreach (var f in fs)
                f.Draw(g);
        }

        public override void Move(int dx, int dy, int dr, PictureBox p)
        {
            foreach (var f in fs)
                f.Move(dx, dy, dr, p);
        }

        public override void SetColor(Color color)
        {
            foreach (var f in fs)
                f.SetColor(color);
        }

        public List<Figure> GetFs()
        {
            return fs;
        }

        public override void Save(string path)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine("G " + fs.Count().ToString());
            }
            foreach (var f in fs)
                f.Save(path);
        }

        public override void Load(StreamReader sr)
        {
            char skip = (char)sr.Read();
            string line = sr.ReadLine();
            int cnt = int.Parse(line);
            for (int i = 0; i < cnt; i++)
            {
                char code = (char)sr.Read();
                MyFigureFactory factory = new MyFigureFactory();
                Figure fig = factory.CreateFigure(code);
                if (fig != null)
                {
                    fig.Load(sr);
                    fs.Add(fig);
                }
            }
        }

        public override int GetX()
        {
            return fs[0].GetX();
        }
        public override int GetY()
        {
            return fs[0].GetY();
        }
    }
}
