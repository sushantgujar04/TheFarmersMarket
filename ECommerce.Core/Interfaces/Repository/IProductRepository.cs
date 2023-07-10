namespace ECommerce.Core.Interfaces.Repository;

public interface IProductRepository
{
    Task<IReadOnlyList<Product>> GetProductsAsync();
    Task<Product> GetProductByIdAsync(int id);

}
