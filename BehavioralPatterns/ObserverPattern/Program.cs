﻿namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock ibm = new IBM("IBM", 120.2);
            var firstInvestor = new Investor("Investor #1");
            ibm.Attach(firstInvestor);
            ibm.Attach(new Investor("Investor #2"));

            ibm.Price = 120.4;
            ibm.Detach(firstInvestor);
            ibm.Price = 125.58;
            ibm.Attach(new Investor("Investor #3"));
            ibm.Price = 120.99;
        }
    }
}
