using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA_05
{
    public class CalculadoraAula05
    {
        double a, b;

        public double Soma()
        {
            Console.WriteLine("Digite o valor de a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de b: ");
           double  b = double.Parse(Console.ReadLine());
            return(a + b);
        }
        public double Sub()
        {
            Console.WriteLine("Digite o valor de a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de b: ");
            double b = double.Parse(Console.ReadLine());
            return (a - b);
        }

        public double Mult()
        {
            Console.WriteLine("Digite o valor de a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de b: ");
            double b = double.Parse(Console.ReadLine());
            return (a * b);
        }

        public double Divi()
        {
            Console.WriteLine("Digite o valor de a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de b: ");
            double b = double.Parse(Console.ReadLine());
            return (a / b);
        }


    }
}
