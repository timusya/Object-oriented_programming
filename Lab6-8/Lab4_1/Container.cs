using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    public class Container : CObject
    {

        private int size;
        private Figure[] arr;
        
        public Container()
        {
            size = 0;
            arr = new Figure[size];
        }

        public int Get_size()
        {
            return size;
        }

        public void Insert(int pos, Figure f)
        {
            Debug.Assert(0 <= pos && pos <= size);
            Figure[] new_arr = new Figure[size + 1];
            for (int i = 0; i < pos; ++i)
            {
                new_arr[i] = arr[i];
            }
            new_arr[pos] = f;
            for (int i = pos + 1; i <= size; ++i)
            {
                new_arr[i] = arr[i - 1];
            }
            size++;
            arr = new_arr;
            NotifyRebuild();
        }

        public Figure this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }

        public void SaveFigures(string path)
        {
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.WriteLine(size.ToString());
            }
            for (int i = 0; i < size; i++)
            {
                arr[i].Save(path);
            }
        }

        public void LoadFigures(string path, FigureFactory factory)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                int cnt = int.Parse(sr.ReadLine());
                for (int i = 0; i < cnt; i++)
                {
                    char code = (char)sr.Read();
                    Figure fig = factory.CreateFigure(code);
                    if (fig != null)
                    {
                        fig.Load(sr);
                        Insert(size, fig);
                    }
                }
               
            }
            NotifyRebuild();
        }
    }
}
