using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    public class Container
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

        /*
        public void Set(int pos, Figure f)
        {
            Debug.Assert(0 <= pos && pos < size);
            arr[pos] = f;
        }
        */

        /*
        public Figure Get(int pos)
        {
            Debug.Assert(0 <= pos && pos < size);
            return arr[pos];
        }
        */

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
        }

        /*
        public void Remove(int pos)
        {
            Debug.Assert(size > 0);
            Debug.Assert(0 <= pos && pos < size);
            size--;
            Figure[] new_arr = new Figure[size];
            for (int i = 0; i < pos; ++i)
            {
                new_arr[i] = arr[i];
            }
            for (int i = pos; i < size; ++i)
            {
                new_arr[i] = arr[i + 1];
            }
            arr = new_arr;
        }
        */

        public Figure this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
    }
}
