using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Consoleteste
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            

            Console.WriteLine("Digite uma das auternativas +, -, *, /");
           string caso =Console.ReadLine();

            Console.WriteLine("Digite o primeiro numero");
            double n1 =double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero");
            double n2 = double.Parse(Console.ReadLine());

            double r = 0;

            switch (caso)
            {
                case "+":
                     r = n1 + n2;
             break;

                case "-":
                     r = n1 - n2;
                    break;

                case "*":
                     r = n1 * n2;
                    break;

                case "/":
                     r = n1 / n2;
                    break;
                default:
                    Console.WriteLine("A auternativa esta incorreta");

                break;
            }

            Console.WriteLine("O resultado foi:" + r);
            Console.ReadKey();




        }
    }
}
