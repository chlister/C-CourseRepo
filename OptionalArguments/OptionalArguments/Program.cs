using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalArguments
{
    class Program
    {
        static void Main(string[] args)
        {

            DisplayPlayerInformation(7, "Ronaldo", 60, "Portugal", "Real Madrid");
            Console.WriteLine("----------------------");
            DisplayPlayerInformation(10, "Messi", 48);

            Console.ReadKey();

        }

        // Primary method - optional arguments
        public static void DisplayPlayerInformation(int no, string name, int goals, string country = "", string club ="")
        {
            Console.WriteLine(no);
            Console.WriteLine(name);
            Console.WriteLine(goals);
            Console.WriteLine(country);
            Console.WriteLine(club);
        }

        // Overload method - no optional arguments
        public static void DisplayPlayerInformation(int no, string name, int goals)
        {
            Console.WriteLine(no);
            Console.WriteLine(name);
            Console.WriteLine(goals);
        }

    }
}
