using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayInformation display = new DisplayInformation();
            Football ft = new Football();
            display.InformationDisplayed += ft.OnInformationDisplayed;
            display.DisplayClub("madrid", "Stefan");

            Console.ReadKey();
        }
    }
    public class Football // reciever
    {
        public Football()
        {

        }
        // Eventhandler is here - We know nothing about the class raising the event
        public void OnInformationDisplayed(object source, EventArgs ea)
        {
            Console.WriteLine("Information was displayed at: " + DateTime.Now.ToShortTimeString());
        }
    }
    public class DisplayInformation // sender
    {
        public delegate void InformationDisplayedEventHandler(object source, EventArgs ea);
        public event InformationDisplayedEventHandler InformationDisplayed;

        public DisplayInformation()
        {

        }
        public void DisplayClub(string clubName, string playerName)
        {
            Console.WriteLine($"{playerName} plays for {clubName}");
            // event is raised here
            OnInformationDisplayed();
        }
        public void DisplayPlayerInformation(string playerName, string clubName)
        {
            Console.WriteLine($"{playerName} currently plays for {clubName}");
            // Event is raised here
            OnInformationDisplayed();
        }
        protected virtual void OnInformationDisplayed()
        {
            InformationDisplayed?.Invoke(this, EventArgs.Empty);
        }
    }
}
