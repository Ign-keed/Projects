using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    internal class MathProgram
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int WholeNum = 5;
            int num2 = 2;
            double Decimal = 4.6;

            double squareRoot = Math.Sqrt(num1);
            Console.WriteLine("Square root of " + num1 + " = " + squareRoot);

            double round = Math.Round(Decimal);
            Console.WriteLine("Rounded value  of " + Decimal + " = " + round);

            double power = Math.Pow(squareRoot, num2);
            Console.WriteLine(WholeNum + " Raise to "  + num2 + " = " + power);

            double low = Math.Min(num1, WholeNum);
            Console.WriteLine("Lowest number = " +  low);

            double high = Math.Max(num1, WholeNum);
            Console.WriteLine("Highest number = " + high);

            Console.ReadKey();

        }
    }
}
