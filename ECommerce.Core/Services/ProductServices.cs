namespace ECommerce.Core.Services;

public class ProductServices : BaseGenericResultHandler, IProductServices
{
    #region Contractor (s) 
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public ProductServices(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this._unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    #endregion

    #region Get All Products

    public async Task<BaseGenericResult<IReadOnlyList<ProductDTo>>> GetAllProductsAsync()
    {
        try
        {
            var result = await _unitOfWork.GProductRepository.ListAllAsync();
            var ListDto = _mapper.Map<IReadOnlyList<ProductDTo>>(result);


            return Success(ListDto);

        }
        catch (Exception ex)
        {
            return InternalServer<IReadOnlyList<ProductDTo>>(ex.Message);
        }
    }
    #endregion

    #region Get Product By Id
    public async Task<BaseGenericResult<ProductDTo>> GetProductByIdAsync(int id)
    {
        try
        {
            var Spec = new ProductWithTypesAndBrandsSpecification(id);
            var result = await _unitOfWork.GProductRepository.GetEntityWithSpec(Spec);
            var Dto = _mapper.Map<ProductDTo>(result);
            return Success(Dto);

        }
        catch (Exception ex)
        {
            return InternalServer<ProductDTo>(ex.Message);
        }
    }


    #endregion


}
