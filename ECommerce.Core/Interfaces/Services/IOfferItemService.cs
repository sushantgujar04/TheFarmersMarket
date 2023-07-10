namespace ECommerce.Core.Interfaces.Services;
public interface IOfferItemService
{
    Task<BaseGenericResult<IReadOnlyList<OfferItemDto>>> GetAllOffersItemsAsync(int offerid);
}
