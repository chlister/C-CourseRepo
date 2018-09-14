using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaWithGenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            list.Add(4); list.Add(2); list.Add(8); list.Add(14); list.Add(11);
            list.Add(6); list.Add(3); list.Add(7); list.Add(12); list.Add(1);

            var oddList = list.Where(n => n%2 != 0).ToList();
            var evenList = list.Where(n => n%2 == 0).ToList();

            Console.WriteLine("Odd list");
            foreach (var item in oddList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Even list");
            foreach (var item in evenList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
