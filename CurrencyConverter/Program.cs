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
            
            OtherCurrencyFunction list = new OtherCurrencyFunction();

            XmlRatesReader reader = new XmlRatesReader();

            Tuple<int, string> intString = new Tuple<int,string>(1234, "date1");
            Tuple<string, string> stringString = new Tuple<string, string>("GBP", "1.5");

            dictionary.Add(intString, stringString);

            list.listInOrderOfStrength(dictionary, "GBP");



            //Currencies currency = new Currencies();
            //Averager averager = new Averager();
            //DatabaseReader reader = new DatabaseReader();

            //Dictionary<string, double> dictionary = reader.dictionaryOfCurrencies();
            //dictionary.Add("1", 1.2);
            //dictionary.Add("2", 1.4);

           // double averageRate = averager.Average(currency, dictionary);

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

