using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Console;

namespace WfaAbstrato
{
    internal class TrianguloIsosceses : Triangulo
    {
        private double baseT;
        private double lado;
        private double Cateto;
        private double CatetoO;
        private double hipo;

        public double Base
        {
            get { return baseT; }
            set { baseT = value; }
        }

        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        public double Hipo
        {
            get { return hipo; }
            set { hipo = value; }
        }


        public override double CalcularArea()
        {
            Cateto = System.Math.Pow(baseT/2, 2);
            CatetoO = System.Math.Pow(lado, 2);

            hipo = System.Math.Sqrt(Cateto - CatetoO);

            return baseT * hipo / 2; 
        }
        public override double CalcularPerimetro()
        {
            return lado * 2 + hipo;

        }

    }
}
