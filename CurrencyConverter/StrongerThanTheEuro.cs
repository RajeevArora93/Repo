using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public class StrongerThanTheEuro
    {
        public void currenciesStrongerThanTheEuro(Dictionary<Tuple<int /*inode*/, string /*date*/>, Tuple<string/*rate*/, string/*currency*/>> dictionaryOfCurrenciesAndExchangeRates, string date)
        {
            foreach (KeyValuePair<Tuple<int, string>, Tuple<string, string>> i in dictionaryOfCurrenciesAndExchangeRates)
            {
                double rate = Convert.ToDouble(i.Value.Item1);

                if (i.Key.Item2.Contains(date) && rate < 1) // If currency exchange rate = 1 then they are the same value, if it is less than one the other currency is stronger
                {
                    Console.WriteLine("{0} : {1} ", i.Value.Item2, i.Value.Item1);



                }
            }
        }
    }
}
