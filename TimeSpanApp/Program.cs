using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TimeSpanApp
{
    class Program
    {
        static void Main(string[] args)
        {

            TimeSpan ts = new TimeSpan(10,78,65);
            Console.WriteLine(ts);

            ts =ts.Add(new TimeSpan(0, 30, 20));

            Console.WriteLine(ts);

            DateTime dt = new DateTime(1999, 10, 30);
            DateTime dt2 = new DateTime(2017, 10, 30);

            // Subtracting two DateTime will always return a timespan
            var sub = dt2 - dt;
            Console.WriteLine(sub.Days/365.25); // divided to give years

            Console.ReadKey();
        }
    }
}
