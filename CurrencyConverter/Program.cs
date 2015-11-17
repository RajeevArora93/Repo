using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static CurrencyConverter currencyConverter = new CurrencyConverter();

        static void Main(string[] args)
        {
            UserInterface userInterface = new UserInterface();

            ExchangeRate();

            Console.ReadLine();
        }

        public static double ExchangeRate()
        {

            Console.WriteLine("What currency would you like to convert to? ");
            string currencyToConvert = Console.ReadLine();

            double exchangeRate = currencyConverter.ConvertCurrency(currencyToConvert);

            Console.WriteLine("Exchange rate is: " + exchangeRate);

            return exchangeRate;
        }

        public double Average()
        {
            Console.WriteLine("For which currency would you like the average? ");
            string currencyToAverage = Console.ReadLine();

            double exchangeRate = currencyConverter.ConvertCurrency(currencyToAverage);//Change this for average function

            Console.WriteLine("Currency average is: " + exchangeRate);

            return exchangeRate; // Change for average currency
        }
    }
}

