using System.Collections.Generic;
using CoinMachine.Coins;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoinMachine.Tests
{
    [TestClass]
    public class CoinSortMachineTest_Given_one_type_of_coin
    {
        [TestMethod]
        public void When_machine_is_fed_with_coins_Then_should_have_same_number_of_coins_sorted()
        {
            CoinSortMachine machine = new CoinSortMachine();
            List<ICoin> coins = new List<ICoin>();
            CoinFactory factory = new CoinFactory();
            coins.AddRange(factory.GetPennies(10));
            machine.FeedCoins(coins);
            Assert.AreEqual(10, machine.Pennies.Count);
        }
    }

    [TestClass]
    public class CoinSortMachineTest_Given_two_types_of_coin
    {
        [TestMethod]
        public void When_machine_is_fed_with_coins_Then_should_sort_into_two_types()
        {
            CoinSortMachine machine = new CoinSortMachine();
            List<ICoin> coins = new List<ICoin>();
            CoinFactory factory = new CoinFactory();
            coins.AddRange(factory.GetPennies(10));
            coins.AddRange(factory.GetNickels(10));
            machine.FeedCoins(coins);
            Assert.AreEqual(10, machine.Pennies.Count);
            Assert.AreEqual(10, machine.Nickels.Count);
        }
    }
}
