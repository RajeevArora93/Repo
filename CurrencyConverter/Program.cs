using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface userInterface = new UserInterface();
            CurrencyConverter currencyConverter = new CurrencyConverter();

            userInterface.UserInputString();

            Console.ReadLine();
        }
    }
}

