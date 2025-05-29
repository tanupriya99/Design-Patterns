using Api.Services;
using Common;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/Cards")]
    public class CardController : Controller
    {
        private ICardService _cardsService;
        public CardController(ICardService service)
        {
            _cardsService = service;
        }

        [HttpGet("")]
        public IEnumerable<Card> GetAll()
        {
            return _cardsService.FetchCards();
        }
    }
}
