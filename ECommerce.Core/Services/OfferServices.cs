namespace ECommerce.Core.Services;

public class OfferServices : BaseGenericResultHandler, IOfferServices
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public OfferServices(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this._unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<BaseGenericResult<IReadOnlyList<OfferDTo>>> GetAllOffersAsync()
    {
        try
        {
            var result = await _unitOfWork.GOfferRepository.ListAllAsync();
            var ListDto = _mapper.Map<IReadOnlyList<OfferDTo>>(result);

            return Success(ListDto);

        }
        catch (Exception ex)
        {
            return InternalServer<IReadOnlyList<OfferDTo>>(ex.Message);
        }
    }


    public async Task<BaseGenericResult<OfferDTo>> GetOfferByCodeAsync(string code)
    {
        try
        {
            var result = await _unitOfWork.OfferRepository.GetOfferByCodeAsync(code);
            var Dto = _mapper.Map<OfferDTo>(result);
            return Success(Dto);

        }
        catch (Exception ex)
        {
            return InternalServer<OfferDTo>(ex.Message);
        }
    }



}
