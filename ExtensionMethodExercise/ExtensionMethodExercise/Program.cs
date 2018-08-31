using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise
            // Extend DateTime - should return a datetime string as (dayName, daynum, month, year)

            Console.WriteLine(DateTime.Now.GetDayNameNumMonthYear());

            Console.ReadKey();
        }
    }
    static class DateTimeExender
    {
        public static string GetDayNameNumMonthYear(this DateTime date)
        {
            return string.Format("{0:dddd dd \nMMMM yyyy}", date);
        }
    }
}
