using System.Collections.Generic;

namespace CoinMachine.Coins
{
    public class CoinFactory
    {
        private Penny penny = null;

        public Penny Penny
        {
            get
            {
                penny = penny ?? new Penny();
                return penny;
            }
        }

        public IList<ICoin> GetPennies(int numberOfPennies)
        {
            IList<ICoin> pennies = new List<ICoin>();
            for (int i = 0; i < numberOfPennies; i++)
            {
                pennies.Add(Penny);
            }
            return pennies;
        }
    }
}
