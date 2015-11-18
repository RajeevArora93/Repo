using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public class OtherCurrencyFunction 
    {

        public List<string> listInOrderOfStrength(Dictionary<Tuple<int, string>, Tuple<string, string>> dictionaryOfCurrenciesAndExchangeRates, string currency)
        {
            //Makes a list of currencies:

            List<string> listOfCurrencies = new List<string>();

            int count = 0;

            foreach (Tuple<string, string> item in dictionaryOfCurrenciesAndExchangeRates.Values.Distinct()) 
            {
                listOfCurrencies.Add(item.Item1);

                count++;
                //foreach (string x in listOfCurrencies)
                //{
                //    Console.WriteLine(x);
                //}
            }

            foreach (Tuple<string, string> rate in dictionaryOfCurrenciesAndExchangeRates.Values)
            {
                Console.WriteLine(rate.Item2);
            }



            double sumOfRates = 0;
            foreach (string curr in listOfCurrencies)
            {
         
                foreach (Tuple<string, string> item in dictionaryOfCurrenciesAndExchangeRates.Values)
                {
                    double rate = double.Parse(item.Item2);
                    sumOfRates += rate;
                }
            }



            return listOfCurrencies;
        }

















        public List<Currencies> currenciesStrongerThanEuro()
        {
            //Do something

            List<Currencies> currenciesStrongerThanEuro = new List<Currencies>();

            return currenciesStrongerThanEuro;
        }

        public List<Currencies> HighestAndLowestCurrencies() // Hayley will do
        {
            //Do something

            List<Currencies> highestAndLowest = new List<Currencies>();

            return highestAndLowest;
        }
    }
}
