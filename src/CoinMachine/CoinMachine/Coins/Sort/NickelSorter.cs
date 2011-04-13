using System.Collections.Generic;

namespace CoinMachine.Coins.Sort
{
    class NickelSorter : CoinSorter
    {
        public NickelSorter(CoinPockets coinPockets) : base(coinPockets) { }

        public override void SortCoinIntoPocket(List<ICoin> coins)
        {
            foreach (ICoin coin in coins)
            {
                if (coin is Nickel)
                    coinPockets.Nickels.Add(coin as Nickel);
            }
            coins.RemoveAll(c => c is Nickel);

            if (coins.Count > 0 && nextSorter != null)
                nextSorter.SortCoinIntoPocket(coins);
        }
    }
}
