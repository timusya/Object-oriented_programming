using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    public class CObject
    {

        public List<CObserver> obs = new List<CObserver>();

        public void AddObserver(CObserver o)
        {
            obs.Add(o);
        }

        //public void RemoveObserver(CObserver o)
        //{
        //    obs.Remove(o);
        //}

        public void NotifyRebuild()
        {
            foreach (var o in obs)
                o.BuildTree();
        }

        public void NotifyMove(int dx, int dy, int dr, PictureBox p)
        {
            foreach (var o in obs)
                o.UpdateMove(dx, dy, dr, p);
        }
    }
}
