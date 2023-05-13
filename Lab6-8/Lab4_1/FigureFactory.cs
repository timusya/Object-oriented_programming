using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    public abstract class FigureFactory
    {
        public abstract Figure CreateFigure(char code);
    }
}
