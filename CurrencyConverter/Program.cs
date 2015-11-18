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
            
            OtherCurrencyFunction list = new OtherCurrencyFunction();

            XmlRatesReader reader = new XmlRatesReader(@"H:\CurrencyConverter\CurrencyConverter\CurrencyConverter\ExchangeRates.xml");

            Dictionary<Tuple<int, string>, Tuple<string, string>> dictionary = reader.GetRatesData();


            list.listOfCurrenciesInOrderOfStrength(dictionary, "2015-11-18");

           //foreach (string x in list1)
           //{
           //    Console.WriteLine(x);
           //}

           Console.ReadLine();










//----------------------------------------INTERFACE------------------------------------------------------------      
      
        //    UserInterface userInterface = new UserInterface();

        //    ExchangeRate();

        //    Console.ReadLine();
        //}

        //public static double ExchangeRate()
        //{

        //    Console.WriteLine("What currency would you like to convert to? ");
        //    string currencyToConvert = Console.ReadLine();

        //    double exchangeRate = currencyConverter.ConvertCurrency(currencyToConvert);

        //    Console.WriteLine("Exchange rate is: " + exchangeRate);

        //    return exchangeRate;
        //}

        //public double Average()
        //{
        //    Console.WriteLine("For which currency would you like the average? ");
        //    string currencyToAverage = Console.ReadLine();

        //    double exchangeRate = currencyConverter.ConvertCurrency(currencyToAverage);//Change this for average function

        //    Console.WriteLine("Currency average is: " + exchangeRate);

        //    return exchangeRate; // Change for average currency

//----------------------------------------INTERFACE------------------------------------------------------------    
        }
    }
}

