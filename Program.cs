using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Lado;
            double a;
            Console.Write("Insira o Lado do Quadrado: ");
            Lado = double.Parse(Console.ReadLine());

            a = Math.Pow(Lado, 2);

            Console.WriteLine("A area do Quadrado é {0}.", a);
        }
    }
}
