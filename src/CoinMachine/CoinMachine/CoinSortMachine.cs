using System.Collections.Generic;
using CoinMachine.Coins;

namespace CoinMachine
{
    public class CoinSortMachine
    {
        public List<Penny> Pennies { get; set; }
        public List<Nickel> Nickels { get; set; }

        public void FeedCoins(IList<ICoin> coins)
        {
            foreach (ICoin coin in coins)
            {
                if (coin is Penny)
                    Pennies.Add(coin as Penny);
                else if (coin is Nickel)
                    Nickels.Add(coin as Nickel);
            }
        }

        public CoinSortMachine()
        {
            Pennies = new List<Penny>();
            Nickels = new List<Nickel>();
        }
    }
}
