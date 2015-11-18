using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public class Averager
    {
        public double Average(string currency, Dictionary<string, List<double>> ListOfRatesPerCurrency)
        {
            double average = 0;

            double sumOfCurrencies = 0;

            var numberOfRates = 0;

            Console.WriteLine(ListOfRatesPerCurrency.Count);
            foreach (KeyValuePair<string, List<double>> entry in ListOfRatesPerCurrency)
                {
                    Console.WriteLine(entry.Value);
                    if(entry.Key == currency)
                    {
                        numberOfRates += entry.Value.Count;

                        Console.WriteLine(numberOfRates);

                        sumOfCurrencies += entry.Value.Sum();
                    }
                    
                }

            Console.WriteLine(numberOfRates);

            average = sumOfCurrencies / numberOfRates;
            
            return Math.Round(average, 2);
        }

        //Recoded to accpet dictionary with double values

        public double Average(string currency, Dictionary<Tuple<int, string>, Tuple<string, string>> DictionaryOfRatesAndCurrencies)
        {
            double average = 0;

            double sumOfCurrencies = 0;

            var numberOfRates = 0;

            Dictionary<string, string> currenciesAndRates = DictionaryOfRatesAndCurrencies.Values.ToDictionary(; //Convert to string string


            //Console.WriteLine(ListOfRatesPerCurrency.Count);
            foreach (KeyValuePair<string, List<double>> entry in currenciesAndRates)
            {
                Console.WriteLine(entry.Value);
                if (entry.Key == currency)
                {
                    numberOfRates += entry.Value.Count;

                    Console.WriteLine(numberOfRates);

                    sumOfCurrencies += entry.Value.Sum();
                }

            }

            Console.WriteLine(numberOfRates);

            average = sumOfCurrencies / numberOfRates;

            return Math.Round(average, 2);
        }
    }
}
