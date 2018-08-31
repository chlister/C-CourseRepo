using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method which takes an array (using params) of any datatype and display the items inside of this array

            DisplayArray(2, 3, 4, 2);
            Console.WriteLine("------------------------");
            DisplayArray("John", "Jill", "Jess");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        private static void DisplayArray<T>(params T[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
