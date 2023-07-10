namespace ECommerce.Core.Interfaces.Services;
public interface IProductServices
{
    Task<BaseGenericResult<IReadOnlyList<ProductDTo>>> GetAllProductsAsync();
    Task<BaseGenericResult<ProductDTo>> GetProductByIdAsync(int id);
}
