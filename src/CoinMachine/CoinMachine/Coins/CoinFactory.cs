using System.Collections.Generic;

namespace CoinMachine.Coins
{
    public class CoinFactory
    {
        private Penny penny = null;
        private Nickel nickel = null;

        public Penny Penny
        {
            get
            {
                penny = penny ?? new Penny();
                return penny;
            }
        }

        public Nickel Nickel
        {
            get
            {
                nickel = nickel ?? new Nickel();
                return nickel;
            }
        }

        public IList<ICoin> GetPennies(int numberOfPennies)
        {
            return GetCoins(Penny, numberOfPennies);

        }

        public IList<ICoin> GetNickels(int numberOfNickels)
        {
            return GetCoins(Nickel, numberOfNickels);
        }

        private IList<ICoin> GetCoins(ICoin coin, int numberOfCoins)
        {
            IList<ICoin> coins = new List<ICoin>();
            for (int i = 0; i < numberOfCoins; i++)
            {
                coins.Add(coin);
            }
            return coins;
        }
    }
}
