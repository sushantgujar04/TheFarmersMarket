namespace ECommerce.Core.Interfaces.Repository;

public interface IUnitOfWork : IDisposable
{
    IProductRepository ProductRepository { get; }
    IGenericRepository<Product> GProductRepository { get; }

    IOfferRepository OfferRepository { get; }
    IGenericRepository<Offer> GOfferRepository { get; }


    IOfferItemRepository OfferItemRepository { get; }
    IGenericRepository<OfferItem> GOfferItemRepository { get; }


    IProductsRepository ProductsRepository { get; }

    void SaveChanges();
    Task SaveChangesAsync();
}
