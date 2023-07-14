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

    public async  Task<IReadOnlyList<OfferItem>> GetOffersAsync()
    {
        // return (Task<IReadOnlyList<OfferItem>>)this._context.OfferItems.Select(x => x.OfferId == offerId);
        return await _context.OfferItems.ToListAsync<OfferItem>();
    }


    

}
