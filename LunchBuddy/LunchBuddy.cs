using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddy
{
    class LunchBuddy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        object restaurant = new Restaurant();

        public LunchBuddy(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void eat()
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} is at {restaurant.Name}.");
        }

        public void eat(string food)
        {
            Console.WriteLine($"{FirstName} {LastName} is eating {food} at the office.");
        }

        public void eat(List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} is at {restaurant.Name} with:");
            companions.ForEach((companion) => Console.WriteLine(companion.FirstName));
        }

        public void eat (string food, List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} is at {restaurant.Name} eating {food} with:");
            companions.ForEach((companion) => Console.WriteLine(companion.FirstName));
        }
    }
}
