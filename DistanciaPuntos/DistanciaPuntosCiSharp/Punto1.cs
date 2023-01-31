using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanciaPuntosCiSharp
{
    class Punto1 : Punto
    {
        public Punto1(double x,double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double DistanciaPunto2(double x,double y)
        {
            return Math.Sqrt(((Math.Pow(x - this.X, 2)) + (Math.Pow(y - this.Y, 2))));
        }
    }
}
