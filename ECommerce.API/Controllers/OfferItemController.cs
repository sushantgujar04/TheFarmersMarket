
using ECommerce.Core.Interfaces.Services;
using ECommerce.Core.Services;

namespace ECommerce.API.Controllers
{
    [ApiController]
    public class OfferItemController : BaseAPIController
    {

        #region Contractor (s)

        private readonly IOfferItemService offerItemService;
        public OfferItemController(IOfferItemService offerItemService)
        {
            this.offerItemService = offerItemService;
        }

        #endregion

        #region Handle of Function (s)

        #region Display List of Product With Filters
        [HttpGet("{offerid}")]
        public async Task<IActionResult> GetAllOffersItems()
        {
            var result = await offerItemService.GetAllOffersItemsAsync();
            return StatusCode(result.StatusCode, result);
        }
        #endregion


        #region Display One Product By Using Id
        #endregion
        #endregion

    }
}