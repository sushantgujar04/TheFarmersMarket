using ECommerce.Core.Interfaces.Repository;

namespace ECommerce.Infrastrucure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDBContext _context;
    private readonly IGenericRepository<Product> g_ProductRepository;
    private readonly IProductRepository _productRepository;
    private readonly IOfferRepository _offerRepository;
    private readonly IGenericRepository<Offer> g_OfferRepository;
    private readonly IOfferItemRepository _offerItemRepository;
    private readonly IGenericRepository<OfferItem> g_OfferItemRepository;

    private readonly IProductsRepository _productsRepository;

    public UnitOfWork(ApplicationDBContext context)
    {
        _context = context;
    }
    public IProductRepository ProductRepository => _productRepository ?? new ProductRepository(_context);
    public IProductsRepository ProductsRepository => _productsRepository ?? new ProductsRepository(_context);

    public IGenericRepository<Product> GProductRepository => g_ProductRepository ?? new GenericRepository<Product>(_context);

    public IOfferRepository OfferRepository => _offerRepository ?? new OfferRepository(_context);

    public IGenericRepository<Offer> GOfferRepository => g_OfferRepository ?? new GenericRepository<Offer>(_context);


    public IOfferItemRepository OfferItemRepository => _offerItemRepository ?? new OfferItemRepository(_context);

    public IGenericRepository<OfferItem> GOfferItemRepository => g_OfferItemRepository ?? new GenericRepository<OfferItem>(_context);

    public void Dispose()
    {
        if (_context != null)
        {
            _context.Dispose();
        }
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}

