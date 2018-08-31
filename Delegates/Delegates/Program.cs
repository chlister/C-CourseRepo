using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        // void delegate with no argument
        public delegate void PlayerInfoDel();
        // void delegate with one argument
        public delegate void PlayerInfoNameDel(string name);
        // void delegate with two arguments
        public delegate void PlayerInfoNameAndGoals(string name, int goals);
        // string delegate with one argument
        public delegate string PlayerNameReturn(int num);
        static void Main(string[] args)
        {
            // Delegate is a reference type that holds the reference to a method

            PlayerInfoDel ronaldo = new PlayerInfoDel(DisplayInformation);
            ronaldo();

            PlayerInfoNameDel playName = new PlayerInfoNameDel(DisplayInformation);
            playName("Messi");

            PlayerNameReturn playerNum = new PlayerNameReturn(DisplayInformation);
            // Invoke is optional
            Console.WriteLine(playerNum.Invoke(8));

            Console.ReadKey();


        }
        public static void DisplayInformation()
        {
            Console.WriteLine("Information about player: Ronaldo");
        }
        public static void DisplayInformation(string playername)
        {
            Console.WriteLine("Information about player: " + playername);
        }
        public static void DisplayInformation(string playername, int goals)
        {
            Console.WriteLine("Information about player: " + playername + " and he scored: " + goals);

        }

        public static string DisplayInformation(int number)
        {
            string playerName = string.Empty;
            switch (number)
            {
                case 7: playerName = "Ronaldo"; break;
                case 8: playerName = "Iniesta"; break;
                case 10: playerName = "Messi"; break;
                default:
                    break;
            }
            return playerName;
        }
    }
}
