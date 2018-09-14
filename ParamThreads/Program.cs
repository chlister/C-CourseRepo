using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParamThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            Helper he = new Helper();
            Thread t1 = new Thread(new ParameterizedThreadStart(he.Loop));
            t1.Start(2);
            Console.ReadKey();
        }
    }
    class Helper
    {
        public void Loop(object number)
        {
            for (int i = 0; i < (int)number; i++)
            {
                Console.WriteLine(i);
            }
        }

    }
}
