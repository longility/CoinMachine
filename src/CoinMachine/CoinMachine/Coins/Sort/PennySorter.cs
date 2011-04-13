using System.Collections.Generic;

namespace CoinMachine.Coins.Sort
{
    public class PennySorter : CoinSorter
    {
        public PennySorter(CoinPockets coinPockets) : base(coinPockets) { }

        public override void SortCoinIntoPocket(List<ICoin> coins)
        {
            foreach (ICoin coin in coins)
            {
                if (coin is Penny)
                    coinPockets.Pennies.Add(coin as Penny);
            }
            coins.RemoveAll(c => c is Penny);

            if (coins.Count > 0 && nextSorter != null)
                nextSorter.SortCoinIntoPocket(coins);
        }
    }
}
