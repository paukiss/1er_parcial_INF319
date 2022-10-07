using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_calc
{
    public class Calculadora
    {
        private double a, b, result;

        public double Result { get => result; set => result = value; }

        public Calculadora(double A, double B)
        {
            a = A;  
            b = B;
        }
        public Calculadora()
        {
            a = b = 0;
        }

        public double sumar()
        {
            result = a + b;
            return Result;
        }

        public double restar()
        {
            result = a - b;
            return Result;
        }

        public double multiplicar()
        {
            result = a * b;
            return Result;
        }

        public double dividir()
        {
            result = a / b;
            return Result;
        }

        public double potencia()
        {
            result = Math.Pow(a, b);
            return Result;
        }

    }
}
