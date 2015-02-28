using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassNewtonMethodTask1;

namespace ConsoleNewtonMethodTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double accurancy = double.Parse(Console.ReadLine());

            double root=NewtonMethod.RootCalculation(value, power, accurancy);

            Console.WriteLine("root of the "+power+"-th degree from "+value+" is "+ root);
            bool rightAnswer=Math.Abs(value - Math.Pow(root, power))<accurancy;
            Console.WriteLine("check by exponentiation : " +  rightAnswer);

        }
    }
}
