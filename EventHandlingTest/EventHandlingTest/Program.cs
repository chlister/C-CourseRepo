using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");

            ViewModel vm = new ViewModel();

            vm.Counter();
            vm.Counter();
            vm.Counter();

            vm.Val++;


            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
    class ViewModel
    {
        int val;
        string _file;
        public int Val
        {
            get
            {
                return val;
            }
            set
            {
                val = value;
                ValueChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public delegate void ValueChangedEventHandler(object source, EventArgs ea);
        public event ValueChangedEventHandler ValueChanged;

        public ViewModel()
        {
            ValueChanged += OnValueChanged;
        }

        public void Counter()
        {
            Val++;
        }

        public void OnValueChanged(object source, EventArgs ea)
        {
            Console.WriteLine("Counter goes up");
        }




        public string File
        {
            get
            {
                return _file;
            }
            set
            {
                _file = value;
                ValueChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public async void OpenFolderAsync(object sender)
        {
            // Lots of folder work

            try
            {
                File = await.openPicker.PickSingleFileAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
