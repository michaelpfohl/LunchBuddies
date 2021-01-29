using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddy
{
    class Restaurant
    {
        public string Name { get; set; }
        private List<string> _restaurants = new List<string> { "Babo", "Chauhan", "Chaatable", "Butcher & Bee" };

        Random random = new Random();
        public Restaurant()
        {
            Name = _restaurants[random.Next(0, _restaurants.Capacity)];
        }
    }
}
