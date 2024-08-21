using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaAbstrato
{
    public class TrianguloReto : Triangulo
    {
        private double baseT;
        private double alt;
        private double Cateto;
        private double CatetoO;
        private double hipo;

        public double Base
        {
            get { return baseT; }
            set { baseT = value; }
        }
        public double Alt
        {
            get { return alt; }
            set { alt = value; }
        }

        public override double CalcularArea()
        {
            return baseT * alt / 2;

        }

        public override double CalcularPerimetro()
        {
            Cateto = System.Math.Pow(baseT, 2);
            CatetoO = System.Math.Pow(alt, 2);

            hipo = System.Math.Sqrt(Cateto + CatetoO);

            return baseT + alt + hipo;
        }

    }
}
