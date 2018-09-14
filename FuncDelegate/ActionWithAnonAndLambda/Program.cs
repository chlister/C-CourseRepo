using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionWithAnonAndLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John Doe";

            //Action
            Action<string> actionMetod = ShowMessage;
            actionMetod(name);

            // Anon method
            Action<string> anonAction = delegate (string myName) { Console.WriteLine($"Hi how are you today, {myName}?") ; };
            anonAction(name);

            //lambda expression
            Action<string> lambdaAction = n => Console.WriteLine($"Hi how are you today, {n}?");
            lambdaAction(name);

            Console.ReadKey();
        }

        public static void ShowMessage (string name)
        {
            Console.WriteLine($"Hi how are you today, {name}?");
        }
    }
}
