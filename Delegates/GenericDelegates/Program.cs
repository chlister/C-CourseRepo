using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegates
{
    class Program
    {
        public delegate T DisplayInfo<T>(T value);
        static void Main(string[] args)
        {
            DisplayInfo<int> myNumber = new DisplayInfo<int>(DisplayValue);

            Console.WriteLine(myNumber(10));

            DisplayInfo<double> myDouble = new DisplayInfo<double>(DisplayValue);

            Console.WriteLine(myDouble(3.89));

            Console.ReadKey();
        }
        public static T DisplayValue<T>(T value)
        {
            Console.WriteLine("Now we are accessing varible type " + value.GetType().Name);
            return value;
        }
    }
}
