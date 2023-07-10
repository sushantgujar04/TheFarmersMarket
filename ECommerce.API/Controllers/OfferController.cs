
using ECommerce.Core.Services;

namespace ECommerce.API.Controllers
{
    [ApiController]
    public class OfferController : BaseAPIController
    {

        #region Contractor (s)

        private readonly IOfferServices offerServices;
        public OfferController(IOfferServices offerServices)
        {
            this.offerServices = offerServices;
        }

        #endregion

        #region Handle of Function (s)

        #region Display List of Product With Filters
        [HttpGet("GetOffers")]
        public async Task<IActionResult> GetOffers()
        {
            var result = await offerServices.GetAllOffersAsync();
            return StatusCode(result.StatusCode, result);
        }
        #endregion


        #region Display One Product By Using Id
        [HttpGet("GetOffersByCode")]
        public async Task<IActionResult> GetOffersByCode(string code)
        {
            var result = await offerServices.GetOfferByCodeAsync(code);
            return StatusCode(result.StatusCode, result);
        }
        #endregion
        #endregion

    }
}