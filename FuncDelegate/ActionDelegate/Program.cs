using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> displayAction = DisplayInformation;
            // With params
            displayAction(16);

            Action displayAction2 = DisplayInformation;
            // no params
            displayAction2();

            Console.ReadKey();
        }
        public static void DisplayInformation(int number)
        {
            Console.WriteLine("Daniele De Rossi number is: " + number);
        }
        public static void DisplayInformation()
        {
            Console.WriteLine("Gabriel Batisu");
        }
    }
}
