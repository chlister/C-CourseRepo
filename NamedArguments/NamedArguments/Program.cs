using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            // Naming the parameters of the method: and give them values
            DislpayPlayerInformation(country: "Portugal", name: "Ronaldo", playergoals: 55, playerno: 7);
            Console.ReadKey();


        }
        public static void DislpayPlayerInformation(int playerno, string name, int playergoals, string country = "")
        {
            Console.WriteLine(playerno);
            Console.WriteLine(name);
            Console.WriteLine(playergoals);
            Console.WriteLine(country);
        }
    }
}
