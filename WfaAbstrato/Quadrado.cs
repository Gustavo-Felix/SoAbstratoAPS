using System;
using System.Globalization;

namespace WfaAbstrato
{
    public class Quadrado : FormaGeometrica
    {

        private double lado;

        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }


        public override double CalcularArea()
        {
            /*return lado * lado;*/
            return Math.Pow(lado, 2);
        }

        public override double CalcularPerimetro()
        {
            return lado * 4;

        }

        public override string ToString()
        {
            string ladoFormatado = lado.ToString("F2", CultureInfo.InvariantCulture).Replace('.', ',');
            return $"Quadrado ({ladoFormatado})";

        }
    }
}
