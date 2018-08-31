using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = 5;

            Console.WriteLine("Non recursive way");
            Console.WriteLine(FactorialNonRecursive(number));
            Console.WriteLine("----------------------------");

            Console.WriteLine("Recursive way");
            Console.WriteLine(Factorial(number));

            Console.WriteLine("----------------------------");
            string path = string.Empty;
            path = @"C:\";
            Console.WriteLine(path);
            ListFolders(path, 0);


            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 

        }

        // Non recursive way
        public static int FactorialNonRecursive(int n)
        {
            if (n == 0)
                return 1;
            int value = 1;
            for (int i = n; i > 0; i--)
            {
                value *= i;
                Console.WriteLine(i);
            }
            return value;
        }

        // recursive way
        public static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            return n * Factorial(n - 1);
        }

        public static void ListFolders(string path, int indent)
        {
            try
            {
                foreach (var folder in Directory.GetDirectories(path))
                {
                    // Each time a new file is found a space matching the "indent" is made
                    Console.WriteLine($"{new string(' ', indent)} {Path.GetFileName(folder)}");
                    ListFolders(folder, indent + 2);
                }

            }
            catch (Exception)
            {
                Debug.WriteLine("No access");
            }

        }

    }
}
