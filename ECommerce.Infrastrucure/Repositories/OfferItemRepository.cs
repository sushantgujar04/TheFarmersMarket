using ECommerce.Core.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Infrastrucure.Repositories;

public class OfferItemRepository : IOfferItemRepository
{
    private readonly ApplicationDBContext _context;

    public OfferItemRepository(ApplicationDBContext context)
    {
        this._context = context;
    }

    public  Task<IReadOnlyList<OfferItem>> GetOffersAsync(int offerId)
    {
        // return (Task<IReadOnlyList<OfferItem>>)this._context.OfferItems.Select(x => x.OfferId == offerId);
        return (Task<IReadOnlyList<OfferItem>>)_context.OfferItems.Where(x => x.OfferId == offerId);
    }

   
}
