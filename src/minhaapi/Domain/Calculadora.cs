using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minhaapi.Domain
{
    public class Calculadora
    {
        public static int Somar(int a, int b)
        {
            return a + b;
        }
        public static int Subtrair(int a, int b)
        {
            return a - b;
        }
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
        public static int Dividir(int a, int b)
        {
            return a / b;
        }

    }
}