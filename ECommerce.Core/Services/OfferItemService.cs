namespace ECommerce.Core.Services;

public class OfferItemService : BaseGenericResultHandler, IOfferItemService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public OfferItemService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this._unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<BaseGenericResult<IReadOnlyList<OfferItemDto>>> GetAllOffersItemsAsync(int offerid)
    {
        try
        {
            var result = await _unitOfWork.OfferItemRepository.GetOffersAsync(offerid);
            var ListDto = _mapper.Map<IReadOnlyList<OfferItemDto>>(result);

            return Success(ListDto);

        }
        catch (Exception ex)
        {
            return InternalServer<IReadOnlyList<OfferItemDto>>(ex.Message);
        }
    }

}
