using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(() => SayHiEnglish());
            Thread t2 = new Thread(() => SayHiDanish());
            t1.Start();
            t2.Start();
            Console.ReadKey();
        }
        public static void SayHiEnglish()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Hello there!");
            }
        }
        public static void SayHiDanish()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("hej med dig!");
            }
        }
    }
}
