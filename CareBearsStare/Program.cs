using System;
using CareBearsStare.Bears;
using System.Collections.Generic;
using System.Linq;

namespace CareBearsStare
{
    class Program
    {
        static void Main(string[] args)
        {

            var definitions = new Dictionary<string, List< string >> ();

            definitions.Add("martin", new List<string> { "smart", "strong", "important"});

            Console.WriteLine(string.Join("you is ", definitions["martin"]));

            var grumpyBear = new GrumpyBear();
            var tenderHeart = new TenderHeart();
            var tinderHeart = new TinderHeart();

            var careBears = new List<CareBearBase> { grumpyBear, tenderHeart, tinderHeart };

            foreach (var bear in careBears)
            {
                bear.Care("Nathan");
                bear.Stare();
            }

            // this is filter?
            var namesThatStartWithT = careBears.Where(bear => bear.Name.StartsWith('T'));
            // this is map
            var careBearName = careBears.Select(bear => bear.Name);

            var careBearNamesThatStartWithT = careBears
                .Where(bear => bear.Name.StartsWith('T'))
                .Select(bear => bear.Name);

            // are there any bears at all. do not combine where and any
            var anyBears = careBears.Any();
            // if there are any matches; finds the first instance and returns/stops
            var anyTinderBears = careBears.Any(bear => bear is TinderHeart);
            // if every bear in our list is a TinderhEart
            var allTinderHearts = careBears.All(bear => bear is TinderHeart);

            // find me the first thing in the list and return it;
            var firstBear = careBears.First();
            // or, I can pass in a boolean expression
            var firstBearStartsWithTY = careBears.First(bear => bear.Name.StartsWith("T"));

            // this does not work because nothing fits what you are looking for
            var blowsUp = careBears.First(bear => bear.Name.StartsWith("T"));

            // this returns null because the default value
            var works = careBears.FirstOrDefault(bear => bear.Name.StartsWith('W'));

            // lists of three with these parameters does not work. skip the first and take the next 2
            var skippedGrumpy = careBears.Skip(1).Take(2);

            var numberOfCharacters = careBears.Sum(bear => bear.Name.Length);

            //var numberOfCharacters2 = careBears.Max(bear => bear.);

            var OrderedBears = careBears.OrderByDescending(bear => bear.BellyBadge);

            //Bedtime Bear, Birthday Bear, Cheer Bear, Friend Bear, Funshine Bear, Good Luck Bear, Grumpy Bear, Love-a-lot Bear, Tenderheart Bear, and Wish Bear.
        }
    }
}
