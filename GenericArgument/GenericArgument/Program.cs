using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericArgument
{
    class Program
    {
        static void Main(string[] args)
        {

            DisplayInfo("John");
            DisplayInfo(2);
            DisplayInfo(2.8);
            DisplayInfo(DateTime.Now);

            var playerInfo = (7, "Ronaldo", 55);
            DisplayInfo(playerInfo);
            
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
        public static void DisplayInfo<T>(T info)
        {
            Console.WriteLine(info);
        }
    }
}
