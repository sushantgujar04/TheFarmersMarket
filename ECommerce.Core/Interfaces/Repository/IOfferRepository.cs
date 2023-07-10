namespace ECommerce.Core.Interfaces.Repository;

public interface IOfferRepository
{
    Task<IReadOnlyList<Offer>> GetOffersAsync();
    Task<Offer> GetOfferByCodeAsync(string code);

}
