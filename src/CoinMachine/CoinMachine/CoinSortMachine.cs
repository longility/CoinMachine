using System.Collections.Generic;
using CoinMachine.Coins;
using CoinMachine.Coins.Sort;

namespace CoinMachine
{
    public class CoinSortMachine
    {
        private CoinPockets coinPockets = new CoinPockets();

        public List<Penny> Pennies { get { return coinPockets.Pennies; } }
        public List<Nickel> Nickels { get { return coinPockets.Nickels; } }

        private readonly CoinSorter coinSortFirstLink;

        public void FeedCoins(List<ICoin> coins)
        {
            coinSortFirstLink.SortCoinIntoPocket(coins);
        }

        public CoinSortMachine()
        {
            this.coinSortFirstLink = new PennySorter(coinPockets);
            coinSortFirstLink.SetNextSorter(new NickelSorter(coinPockets));
        }
    }
}
