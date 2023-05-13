using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    class MyFigureFactory : FigureFactory
    {
        public override Figure CreateFigure(char code)
        {
            Figure fig = null;
            if (code == 'C')
                fig = new CCircle(0, 0, 0);
            else if (code == 'S')
                fig = new Square(0, 0, 0);
            else if (code == 'T')
                fig = new Triangle(0, 0, 0);
            else if (code == 'G')
                fig = new Group();
            return fig;
        }
    }
}
