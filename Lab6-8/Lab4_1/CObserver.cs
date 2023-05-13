using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    public interface CObserver
    {
        void BuildTree();

        void UpdateMove(int dx, int dy, int dr, PictureBox p);
    }
}
