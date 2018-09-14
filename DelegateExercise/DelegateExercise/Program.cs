using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExercise
{
    class Program
    {
        static Dictionary<int, string> dict = new Dictionary<int, string>() { {1, "Jane"}, {2, "Joe"}, {3,"Mille"}, {4,"Morten"}, {5,"Mort"} };
        public delegate void ReadDictionary(Dictionary<int, string> dict);
        static void Main(string[] args)
        {
            ReadDictionary RD = new ReadDictionary(DisplayDictionary);

            RD(dict);

            Console.ReadKey();
        }
        public static void DisplayDictionary(Dictionary<int, string> dic)
        {
            foreach (var item in dic)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
