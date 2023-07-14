namespace ECommerce.Core.Interfaces.Repository;

public interface IOfferItemRepository
{
    Task<IReadOnlyList<OfferItem>> GetOffersAsync();

}
