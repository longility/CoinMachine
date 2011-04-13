
using System.Collections.Generic;
namespace CoinMachine.Coins.Sort
{
    public class CoinPockets
    {
        public List<Penny> Pennies { get; set; }
        public List<Nickel> Nickels { get; set; }

        public CoinPockets()
        {
            Pennies = new List<Penny>();
            Nickels = new List<Nickel>();
        }
    }
}
