namespace ECommerce.Infrastrucure.Repositories;

public class OfferRepository : IOfferRepository
{
    private readonly ApplicationDBContext _context;

    public OfferRepository(ApplicationDBContext context)
    {
        this._context = context;
    }

    public async Task<Offer> GetOfferByCodeAsync(string code)
    {
        return await _context.Offers.FirstOrDefaultAsync(x => x.Code == code);

    }

    public async Task<IReadOnlyList<Offer>> GetOffersAsync()
    {
        return await _context.Offers.ToListAsync();

    }

}
