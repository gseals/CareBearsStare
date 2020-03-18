using System;
using System.Collections.Generic;
using System.Text;

namespace CareBearsStare.Bears
{
    class TenderHeart : CareBearBase
    {

        public TenderHeart()
        {
            Name = "Tender Heart";
            BellyBadge = "Heart";
            Color = BearColor.Brown;
        }
        // override is counterpart to abstract and virtual. this says "I want to change the initial behavior into something that I choose."
        public override void Stare()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{Name} shoots hearts from his belly.");
            Console.ResetColor();
        }
    }
}
