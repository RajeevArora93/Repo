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

            //----------------------------------------INTERFACE------------------------------------------------------------  
            XmlRatesReader reader = new XmlRatesReader(@"H:\Downloads\Repo-master\Repo-master\CurrencyConverter\ExchangeRates.xml");
            Dictionary<Tuple<int, string>, Tuple<string, string>> dictionary = reader.GetRatesData();
            OrderByStrength funcs = new OrderByStrength();
            List<string> currencies = funcs.ExtractCurrencies(dictionary);
            CurrencyConverter converter = new CurrencyConverter();

            OrderByStrength compare = new OrderByStrength();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
        Main:
            Console.WriteLine();
            Console.WriteLine("-------------------------- What would you like to do? --------------------------");
            Console.WriteLine();
            Console.WriteLine("Selet option by number: ");
            Console.WriteLine("1. Convert currency");
            Console.WriteLine("2. List currency by strength");
            Console.WriteLine("3. List currencies stronger than euro");
            Console.WriteLine("4. Show highest and lowest for each currency compared to euro");
            Console.WriteLine("5. list 10 currencies with smallest change against the euro");
            Console.WriteLine();

            string firstInput = Console.ReadLine();

            if (firstInput == "1")
            {
            Start:
                Console.WriteLine("----------------- Which currency would you like to convert to? -----------------");
                Console.WriteLine();
                Console.WriteLine("If you would like to see all options press: a \nIf you would like to see conversion rates by date press: d \nOtherwise enter a code");
                Console.WriteLine("To go to the main page press: m");
                Console.WriteLine();

                string input2 = Console.ReadLine();
                if (input2 == "a")
                {
                    Console.WriteLine("USD");
                    Console.WriteLine("JPY");
                    Console.WriteLine("BGN");
                    Console.WriteLine("CZK");
                    Console.WriteLine("DKK");
                    Console.WriteLine("GBP");
                    Console.WriteLine("HUF");
                    Console.WriteLine("PLN");
                    Console.WriteLine("RON");
                    Console.WriteLine("SEK");
                    Console.WriteLine("CHF");
                    Console.WriteLine("NOK");
                    Console.WriteLine("HRK");
                    Console.WriteLine("RUB");
                    Console.WriteLine("TRY");
                    Console.WriteLine("AUD");
                    Console.WriteLine("BRL");
                    Console.WriteLine("CAD");
                    Console.WriteLine("CNY");
                    Console.WriteLine("HKD");
                    Console.WriteLine("IDR");
                    Console.WriteLine("ILS");
                    Console.WriteLine("INR");
                    Console.WriteLine("KRW");
                    Console.WriteLine("MXN");
                    Console.WriteLine("MYR");
                    Console.WriteLine("NZD");
                    Console.WriteLine("PHP");
                    Console.WriteLine("SGD");
                    Console.WriteLine("THB");
                    Console.WriteLine("ZAR");
                    Console.ReadLine();
                    goto Start;
                }
                else if (currencies.Contains(input2))
                {
                    Console.WriteLine("How much would you like to convert in Euros?");
                    double amount = Convert.ToDouble(Console.ReadLine());

                    double convertedAmount = converter.ConvertCurrencyByValue(dictionary, input2, "2015-11-18", amount);
                    Console.WriteLine(convertedAmount + " " + input2);

                    Console.ReadLine();

                    goto Start;
                }
                else if (input2 == "d")
                {
                    Console.WriteLine("Enter date in the form: YYYY-MM-DD");
                    string date = Console.ReadLine();

                    Console.WriteLine("Enter currency code:");
                    string code = Console.ReadLine();

                    converter.ConvertCurrency(dictionary, code, date);
                    Console.ReadLine();
                    goto Start;
                }
                else if (input2 == "m")
                {
                    goto Main;
                }
                else
                {
                    Console.WriteLine("Please enter a currency code");
                    goto Start;
                }
            }
            else if (firstInput == "2")
	        {
                Console.WriteLine("Enter date:");
                string date = Console.ReadLine();
                compare.listOfCurrenciesInOrderOfStrength(dictionary, date);

                goto Main;
	        }

            Console.ReadLine();
            //----------------------------------------INTERFACE------------------------------------------------------------    
        }
    }
}

