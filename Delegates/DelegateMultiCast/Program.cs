using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateMultiCast
{
    class Program
    {
        public delegate void SayHiDelegate();
        static void Main(string[] args)
        {
            SayHiDelegate sayHi = null;

            sayHi = new SayHiDelegate(SayHiDanish);
            sayHi += new SayHiDelegate(SayHiGerman);
            sayHi += new SayHiDelegate(SayHiEnglish);
            sayHi += new SayHiDelegate(SayHiSpanish);

            sayHi();

            Console.ReadKey();
        }
        public static void SayHiDanish()
        {
            Console.WriteLine("Hej!");
        }
        public static void SayHiGerman()
        {
            Console.WriteLine("Hallo!");
        }
        public static void SayHiEnglish()
        {
            Console.WriteLine("Hi there!");
        }
        public static void SayHiSpanish()
        {
            Console.WriteLine("Hola!");
        }
    }
}
