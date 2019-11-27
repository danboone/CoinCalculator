using System;
using System.Collections.Generic;

namespace CoinCalculator.Data
{
    public class CoinsCalculate
    {
        private readonly decimal Quarter = .25m;
        private readonly decimal Dime = .10m;
        private readonly decimal Nickel = .05m;
        private readonly decimal Penny = .01m;
        public CoinsCalculate() {}

        public List<string> GetCoins(decimal v)
        {
            var result = new List<string>();

            if((int)(v / Quarter) >= 1) 
                result.Add((int)(v / Quarter) + " Quarter");
            v %= Quarter;
            if ((int)(v / Dime) >= 1) 
                result.Add((int)(v / Dime) + " Dime");
            v %= Dime;
            if ((int)(v / Nickel) >= 1)
                result.Add((int)(v / Nickel) + " Nickel");
            v %= Nickel;
            if ((int)(v / Penny) >= 1)
                result.Add((int)(v / Penny) + " Penny");
            return result;
        }
    }
}