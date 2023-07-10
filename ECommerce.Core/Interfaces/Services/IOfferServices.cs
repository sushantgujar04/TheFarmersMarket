namespace ECommerce.Core.Interfaces.Services;
public interface IOfferServices
{
    Task<BaseGenericResult<IReadOnlyList<OfferDTo>>> GetAllOffersAsync();
    Task<BaseGenericResult<OfferDTo>> GetOfferByCodeAsync(string code);
}
