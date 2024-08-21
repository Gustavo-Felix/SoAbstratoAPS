using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaAbstrato
{
    public abstract class Retangulo : FormaGeometrica
    {
        private double baseT;

        public double Base
        {
            get { return baseT; }
            set { baseT = value; }
        }

        private double alt;

        public double Alt
        {
            get { return alt; }
            set { alt = value; }
        }

        public override double CalcularArea()
        {
            return (baseT * alt);

        }
        public override double CalcularPerimetro()
        {
            return ((baseT * 2) + (alt * 2));

        }
    }
}
