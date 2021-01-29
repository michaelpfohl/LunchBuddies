using System;
using System.Collections.Generic;

namespace LunchBuddy
{
    class Program
    {
        static void Main(string[] args)
        {
            var lunchBuddy1 = new LunchBuddy("Amanda", "Brooker");
            var lunchBuddy2 = new LunchBuddy("Jameson", "Mohr");
            var lunchBuddy3 = new LunchBuddy("Gary", "DiFiore");

            List<LunchBuddy> lunchBuddies = new List<LunchBuddy> {lunchBuddy2, lunchBuddy3 };

            lunchBuddy1.eat();
            lunchBuddy1.eat("Mac & Cheese");
            lunchBuddy1.eat(lunchBuddies);
            lunchBuddy1.eat("Mac & Cheese",lunchBuddies);
        }
    }
}
