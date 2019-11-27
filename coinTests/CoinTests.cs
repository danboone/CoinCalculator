using System;
using Xunit;
using CoinCalculator.Data;
using System.Collections.Generic;
using System.Linq;

namespace coinTests
{
    public class CoinTests
    {
        private readonly CoinsCalculate coins = new CoinsCalculate();
        [Fact]
        public void InitiateClass()
        {
            Assert.NotNull(coins);
        }
        [Fact]
        public void callclass()
        {
            var totals = coins.GetCoins(.10m);
            Assert.NotNull(totals);
        }
        [Fact]
        public void ReturnsString()
        {
            var totals = coins.GetCoins(1.00m);
            Assert.IsType<List<string>>(totals);
        }
        [Fact]
        public void Calculates4quarter()
        {
            var x = 1.00m;
            var totals = coins.GetCoins(x);
            Assert.True(totals.Count == 1);
            foreach(var total in totals)
                Assert.True(total== "4 Quarter");
        }
        [Fact]
        public void Calculates20Quarter()
        {
            var x = 5.00m;
            var totals = coins.GetCoins(x);
            Assert.True(totals.Count == 1);
            foreach (var total in totals)
                Assert.True(total == "20 Quarter");
           
        }
        [Fact]
        public void Calculate1Quarter()
        {
            var x = .25m;
            var totals = coins.GetCoins(x);
            Assert.True(totals.Count == 1);
            foreach (var total in totals)
                Assert.True(total == "1 Quarter");            
        }
        [Fact]
        public void Calculate1Quareterand1Dime()
        {
            var x = .35m;
            var totals = coins.GetCoins(x);
            Assert.True(totals.Count == 2);
            foreach (var total in totals)
                Assert.True(total == "1 Quarter" || total == "1 Dime");
            
        }
        [Fact]
        public void Calculate1Dime()
        {
            var x = .10m;
            var totals = coins.GetCoins(x);
            Assert.True(totals.Count == 1);
            foreach (var total in totals)
                Assert.True(total == "1 Dime");
            
        }
        [Fact]
        public void Calculate2Dime()
        {
            var x = .20m;
            var totals = coins.GetCoins(x);
            Assert.True(totals.Count == 1);
            foreach (var total in totals)
                Assert.True(total == "2 Dime");
            
        }
        [Fact]
        public void Calculate1Nickle()
        {
            var x = .05m;
            var totals = coins.GetCoins(x);
            Assert.True(totals.Count == 1);
            foreach (var total in totals)
                Assert.True(total == "1 Nickel");            
        }
        [Fact]
        public void Calculate1Quareterand1Dime1Nickel()
        {
            var x = .40m;
            var totals = coins.GetCoins(x);
            Assert.True(totals.Count == 3);
            Assert.True("1 Quarter" == totals.Where(c => c.Contains("Quarter")).FirstOrDefault());
            Assert.True("1 Dime" == totals.Where(c => c.Contains("Dime")).FirstOrDefault());
            Assert.True("1 Nickel" == totals.Where(c => c.Contains("Nickel")).FirstOrDefault());
            
        }
        [Fact]
        public void Calculate1Penny()
        {
            var x = .01m;
            var totals = coins.GetCoins(x);
            Assert.True(totals.Count == 1);
            Assert.True("1 Penny" == totals.Where(c => c.Contains("Penny")).FirstOrDefault()); 
            
        }
        [Fact]
        public void Calculate2Dimeand4Penny()
        {
            var x = .24m;
            var totals = coins.GetCoins(x);
            Assert.True(totals.Count == 2);
            Assert.True("2 Dime" == totals.Where(c => c.Contains("Dime")).FirstOrDefault());
            Assert.True("4 Penny" == totals.Where(c => c.Contains("Penny")).FirstOrDefault());
            
        }
    }
}
