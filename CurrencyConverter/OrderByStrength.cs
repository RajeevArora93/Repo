using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public class OrderByStrength 
    {
        public List<string> ExtractCurrencies(Dictionary<Tuple<int, string>, Tuple<string, string>> dictionaryOfCurrenciesAndExchangeRates)
        {
            //Makes a list of currencies:

            List<string> listOfCurrencies = new List<string>();

            int count = 0;

            foreach (KeyValuePair<Tuple<int, string>, Tuple<string, string>> item in dictionaryOfCurrenciesAndExchangeRates)
            {
                if(!listOfCurrencies.Contains(item.Value.Item2))
                {
                    listOfCurrencies.Add(item.Value.Item2);
                }

                count++;

            }
            return listOfCurrencies;
        }


        public List<string> ExtractDate(Dictionary<Tuple<int, string>, Tuple<string, string>> dictionaryOfCurrenciesAndExchangeRates)
        {
            //Makes a list of dates:
            List<string> listOfDates = new List<string>();

            int count = 0;

            foreach (KeyValuePair<Tuple<int, string>, Tuple<string, string>> item in dictionaryOfCurrenciesAndExchangeRates)
            {
                if (!listOfDates.Contains(item.Key.Item2))
                {
                    listOfDates.Add(item.Key.Item2);
                }

                count++;

            }
            return listOfDates;
        }


        public void listOfCurrenciesInOrderOfStrength(Dictionary<Tuple<int, string>, Tuple<string, string>> dictionaryOfCurrenciesAndExchangeRates, string date )
        {

            SortedDictionary<double, string> dictionary = new SortedDictionary<double, string>();
            foreach (KeyValuePair<Tuple<int, string>, Tuple<string, string>> i in dictionaryOfCurrenciesAndExchangeRates)
            {
                double rateOfE = double.Parse(i.Value.Item1);
                
                if (i.Key.Item2.Contains(date))
                {
                    dictionary.Add(Convert.ToDouble(i.Value.Item1), i.Value.Item2);
                }
            }
            Console.WriteLine();
            foreach (KeyValuePair<double, string> str in dictionary)
            {
                Console.WriteLine("{0} : {1}", str.Value, str.Key);
                
            }
            Console.ReadLine();
        }
    }
}
