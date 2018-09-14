using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncAnonAndLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John Doe";

            //Func
            Func<string, string> ConvertToUppercase = UppercaseString;
            Console.WriteLine("using func");
            Console.WriteLine(ConvertToUppercase(name));

            // Anon method
            Func<string, string> anonMethod = delegate (string myName) { return myName.ToUpper(); };
            Console.WriteLine("Using anon method");
            Console.WriteLine(anonMethod(name));
            //lambda expression
            Func<string, string> lambdaMethod = n => n.ToUpper();
            Console.WriteLine("Using Lambda Expression");
            Console.WriteLine(lambdaMethod(name));
            Console.ReadKey();
        }

        private static string UppercaseString(string arg)
        {
            return arg.ToUpper();
        }
    }
}
