﻿using Common;

namespace Api.Services
{
    public interface ICardsService
    {
        IEnumerable<Card> FetchCards();
    }
}
