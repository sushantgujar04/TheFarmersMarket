#region Fields
namespace ECommerce.API.Controllers;

[ApiController]

public class ProductController : BaseAPIController
{
    #endregion

    #region Contractor (s)

    private readonly IProductServices productServices;
    public ProductController(IProductServices productServices)
    {
        this.productServices = productServices;
    }

    #endregion

    #region Handle of Function (s)

    #region Display List of Product With Filters
    [HttpGet(Router.SpecProduct.ListProduct)]
    public async Task<IActionResult> GetProducts()
    {
        var result = await productServices.GetAllProductsAsync();
        return StatusCode(result.StatusCode, result);
    }
    #endregion


    #region Display One Product By Using Id
    [HttpGet(Router.SpecProduct.GetById)]
    public async Task<IActionResult> GetProductById(int id)
    {
        var result = await productServices.GetProductByIdAsync(id);
        return StatusCode(result.StatusCode, result);
    }
    #endregion 

}
#endregion
