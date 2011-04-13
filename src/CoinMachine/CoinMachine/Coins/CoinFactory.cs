using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoinMachine.Coins
{
    public static class CoinFactory
    {
        public static IList<ICoin> CreatePennies(int numberOfPennies)
        {
            IList<ICoin> pennies = new List<ICoin>();
            for (int i = 0; i < numberOfPennies; i++)
            {
                pennies.Add(new Penny());
            }
            return pennies;
        }
    }
}
