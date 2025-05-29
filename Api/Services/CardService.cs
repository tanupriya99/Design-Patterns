﻿using Common;
using System.Resources;

namespace Api.Services
{
    public class CardService : ICardService
    {
        public IEnumerable<Card> FetchCards()
        {
            return new List<Card>()
            {
                new Card() { Attack = 90, Defense = 80, Name = "Ultimate Shadow Wraith" },
                new Card() { Attack = 64, Defense = 91, Name = "Puppet of Doom" },
                new Card() { Attack = 77, Defense = 61, Name = "Lost Soul" },
                new Card() { Attack = 55, Defense = 57, Name = "Plague Druid" },
                new Card() { Attack = 90, Defense = 95, Name = "Rage Dragon" }
            };
        }
    }
}
