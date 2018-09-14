using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethods
{
    class Program
    {
        delegate void DisplayInfo();
        delegate void DisplayInfoBasedOnNumber(int number);

        static void Main(string[] args)
        {
            DisplayInfo normalDelegate = new DisplayInfo(GetInformation);
            normalDelegate();

            DisplayInfoBasedOnNumber oneParam = new DisplayInfoBasedOnNumber(GetInformation);
            oneParam(4);


            Console.WriteLine("--------------------------");
            DisplayInfo normalDelegateAnon = delegate { Console.WriteLine("Hi from a anon method!"); };
            normalDelegateAnon();

            DisplayInfoBasedOnNumber anonParamDel = delegate (int number) { Console.WriteLine("Hi from the anon method wich takes a param: " + number); };
            anonParamDel(5656);

            Console.ReadKey();
        }

        private static void GetInformation()
        {
            // Some logic goes here
            Console.WriteLine("Delegate with no params");
        }
        public static void GetInformation(int x)
        {
            // some logic goes here 
            Console.WriteLine("Delegate with one param: " + x);
        }
    }
}
