using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace WfaAbstrato
{
    internal class TrianguloEquilatero : Triangulo
    {
        private double baseT;

        public double Base
        {
            get { return baseT; }
            set { baseT = value; }
        }

        public override double CalcularArea()
        {
            return (Math.Sqrt(3) / 4) * Math.Pow(baseT, 2);

        }
        public override double CalcularPerimetro()
        {
            return 3 * baseT;
         
        }

    }
}
