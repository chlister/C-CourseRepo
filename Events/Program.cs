using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void myDelegate(string name);
    class Program
    {
        public event myDelegate myEvent;
        public Program()
        {
            myEvent += new myDelegate(SayHiEnglish);
        }
        static void Main(string[] args)
        {

            Console.ReadKey();

        }
        public void SayHiEnglish(string name)
        {
            Console.WriteLine("Hi " + name);

        }
        public void SayHiSpanish(string name)
        {
            Console.WriteLine("Hola " + name);
        }
        public void SayHiGerman(string name)
        {
            Console.WriteLine("Mojn " + name);
        }
        public void SayHiSwedish(string name)
        {
            Console.WriteLine("Hej do " + name);
        }
    }
}
