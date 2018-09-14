using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        delegate void DisplayMessage();
        delegate int Multiply(int n);
        static void Main(string[] args)
        {
            // no lambda!
            Multiply multiNum = delegate (int n) { { return n * 3; } };
            // With lambda
            Multiply lambdaMulti = n => n*3;

            Console.WriteLine(multiNum(55));
            Console.WriteLine(lambdaMulti(22));

            DisplayMessage mess = () => Console.WriteLine("No params here") ;

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
