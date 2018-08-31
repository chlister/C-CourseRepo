using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuplesExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Tuple<int, string, string, DateTime>> Employees = new List<Tuple<int, string, string, DateTime>>
            {
                new Tuple<int, string, string, DateTime>(3, "James", "Johnson", new DateTime(1998,10,2)),
                new Tuple<int, string, string, DateTime>(1, "Albert", "Bensen", new DateTime(1997,10,5)),
                new Tuple<int, string, string, DateTime>(7, "Humert", "Xavie", new DateTime(1988,11,6)),
                new Tuple<int, string, string, DateTime>(4, "Olga", "Ron", new DateTime(1974,8,4)),
                new Tuple<int, string, string, DateTime>(12, "Alloy", "Yolla", new DateTime(1936,1,20)),
                new Tuple<int, string, string, DateTime>(9, "Gert", "Mullo", new DateTime(1985,3,24)),
                new Tuple<int, string, string, DateTime>(11, "Zhu", "Yus", new DateTime(2001,12,12))

            };

            DisplayList(Employees);
            Employees.Sort();

            DisplayList(Employees);

            Employees.Reverse();

            DisplayList(Employees);

            Console.ReadKey();


        }
        static void DisplayList(List<Tuple<int, string, string, DateTime>> TupleList)
        {
            foreach (var item in TupleList)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("--------------------");

        }
    }
}
