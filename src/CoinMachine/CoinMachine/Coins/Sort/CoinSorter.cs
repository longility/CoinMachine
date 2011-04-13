using System.Collections.Generic;

namespace CoinMachine.Coins.Sort
{
    public abstract class CoinSorter
    {
        protected CoinSorter nextSorter = null;
        protected readonly CoinPockets coinPockets = null;

        protected CoinSorter(CoinPockets coinPockets)
        {
            this.coinPockets = coinPockets;
        }

        public void SetNextSorter(CoinSorter nextSorter)
        {
            this.nextSorter = nextSorter;
        }

        public abstract void SortCoinIntoPocket(List<ICoin> coins);
    }
}
