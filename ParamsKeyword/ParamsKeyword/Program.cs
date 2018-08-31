using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            LoopThroughArray(new string[5] { "Jack", "Tiffany", "Sandra", "Huckles", "Jane" });
            Console.WriteLine("-----------------------------");
            LoopThroughArray("Betty", "Blade", "Thomas" , "Jimmy", "Jack");

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        // Params keyword can be used to accept a number of, in this case, strings as an array - No need to initialise it 
        private static void LoopThroughArray(params string[] names)
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
