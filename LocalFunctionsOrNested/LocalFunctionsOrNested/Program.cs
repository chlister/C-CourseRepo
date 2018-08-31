using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFunctionsOrNested
{
    class Program
    {
        static void Main(string[] args)
        {

            PerformMathOperation(2, 5, 6, 2);
            PerformMathOperation(1, 10, 44, 2);
            PerformMathOperation(2, 333);



            Console.ReadKey();
        }
        public static void PerformMathOperation(params int[] numbers)
        {
            Console.WriteLine("Add = " + AddNumbers());
            int AddNumbers()
            {
                int result = 0;
                foreach (var num in numbers)
                {
                    result = result + num;
                }
                return result;
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine("Multi = " + MultiplyNumbers());
            int MultiplyNumbers()
            {
                int result = 1;
                foreach (var num in numbers)
                {
                    result = result * num;
                }
                return result;
            }
            Console.WriteLine("-----------------------");

        }
    }
}
