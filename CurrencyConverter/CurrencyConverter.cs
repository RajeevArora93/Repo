﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public class CurrencyConverter
    {

        //This converter takes in a currency string
        public void ConvertCurrency(Dictionary<Tuple<int /*inode*/, string /*date*/>, Tuple<string/*rate*/, string/*currency*/>> dictionaryOfCurrenciesAndExchangeRates, string currencyToConvert)
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------ Rates by date: ---------------------------");

            foreach (KeyValuePair<Tuple<int, string>, Tuple<string, string>> i in dictionaryOfCurrenciesAndExchangeRates)
            {
                if (i.Value.Item2.Contains(currencyToConvert))
                {
                    Console.WriteLine("{0} : {1}", i.Key.Item2, i.Value.Item1);
                }
            }
        }

        // This converter takes in a currency string and a date string
        public void ConvertCurrency(Dictionary<Tuple<int /*inode*/, string /*date*/>, Tuple<string/*rate*/, string/*currency*/>> dictionaryOfCurrenciesAndExchangeRates, string currencyToConvert, string date)
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------ Rates by date: ---------------------------");

            foreach (KeyValuePair<Tuple<int, string>, Tuple<string, string>> i in dictionaryOfCurrenciesAndExchangeRates)
            {
                if (i.Value.Item2.Contains(currencyToConvert))
                {
                    if (i.Key.Item2.Contains(date))
                    {
                        Console.WriteLine("{0} : {1}", i.Key.Item2, i.Value.Item1);
                    }
                }
            }
        }

        public double ConvertCurrencyByValue(Dictionary<Tuple<int, string>, Tuple<string, string>> dictionary, string CurrencyToConvert, string date, double amountToConvert)
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------ Conversion: ---------------------------");
            double conversionRate = 0;
            foreach (KeyValuePair<Tuple<int, string>, Tuple<string, string>> i in dictionary)
            {
                if (i.Value.Item2.Contains(CurrencyToConvert))
                {
                    if (i.Key.Item2.Contains(date))
                    {
                        conversionRate = Convert.ToDouble(i.Value.Item1);
                        //Console.WriteLine("{0} : {1}", i.Key.Item2, i.Value.Item1);
                    }

                }
            }

            double exchange = amountToConvert * conversionRate;

            return Math.Round(exchange, 2);
        }
    }
}
