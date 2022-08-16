using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            string op;
            double resultado;

            Console.WriteLine("Introduzca el nombre de la operación que quiera realizar");
            Console.WriteLine("SUMAR");
            Console.WriteLine("RESTAR");
            Console.WriteLine("MULTIPLICAR");
            Console.WriteLine("DIVIDIR");

            op = Console.ReadLine();

            Console.WriteLine("Introduzca el primer número");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo número");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            if(op == "SUMAR")
            {
                resultado = num1 + num2;
                Console.WriteLine("El resultado de la operación es: "+resultado);
                Console.ReadLine();
            }
            else if (op == "RESTAR")
            {
                resultado = num1 - num2;
                Console.WriteLine("El resultado de la operación es: " + resultado);
                Console.ReadLine();
            }

            else if (op == "MULTIPLICAR")
            {
                resultado = num1 * num2;
                Console.WriteLine("El resultado de la operación es: " + resultado);
                Console.ReadLine();
            }

            else if (op == "DIVIDIR")
            {
                resultado = num1 / num2;
                Console.WriteLine("El resultado de la operación es: " + resultado);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("LA OPERACION NO SE PUEDE REALIZAR");
                Console.ReadLine();
            }
        }
    }
}
