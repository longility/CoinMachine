using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinMachine.Coins;

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
            
            coins.AddRange(CoinFactory.CreatePennies(10));
            machine.FeedCoins(coins);
            Assert.AreEqual(10, machine.Pennies.Count);
        }
    }
}
