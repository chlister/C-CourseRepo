using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int,int> funcone = AddTwoNumbers;
            Console.WriteLine(  AddTwoNumbers(3, 10));

            Func<int> functwo = AddTwoNumbers;
            Console.WriteLine(funcone(2, 5));

            Console.ReadKey();
        }
        public static int AddTwoNumbers(int x, int y)
        {
            return x+y;
        }
        public static int AddTwoNumbers()
        {
            int z = 0;
            int x = 5;
            int y = 2;

            z = x + y;
            return z;
        }
    }
}
