using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoinMachine.Coins;

namespace CoinMachine
{
    public class CoinSortMachine
    {
        public List<Penny> Pennies { get; set; }
        public void FeedCoins(IList<ICoin> coins)
        {
            foreach (ICoin coin in coins)
            {
                if (coin is Penny)
                    Pennies.Add(coin as Penny);
            }
        }

        public CoinSortMachine()
        {
            Pennies = new List<Penny>();
        }
    }
}
