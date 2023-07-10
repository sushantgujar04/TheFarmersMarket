namespace ECommerce.Infrastrucure.Repositories;

public class ProductsRepository : IProductsRepository
{
    private readonly ApplicationDBContext _context;
    public ProductsRepository(ApplicationDBContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Product>> GetListOfProductsAsync()
    {
        return await _context.Products.ToListAsync();
    }

    public async Task<Product> GetProductByIDAsync(int id) => await _context.Products.FirstOrDefaultAsync(x => x.Id == id)!;
}
