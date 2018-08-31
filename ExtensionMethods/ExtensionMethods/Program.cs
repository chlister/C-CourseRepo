using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 0;
            
            Console.WriteLine(x.IsGreater(20));
            string text = "Marc";
            
            Console.WriteLine(text.IsNumber());
            string text2 = "4";
            Console.WriteLine(text2.IsNumber());
            Console.ReadKey();

        }
    }
    static class MyCustomExtension
    {
        public static bool IsGreater(this int value, int number)
        {
            return value > number;
        }
        public static bool IsNumber(this string text)
        {
            return int.TryParse(text, out int result);
        }
    }
}
