namespace ECommerce.Core.Mappings;

public class AutomapperProfile : Profile
{
    public AutomapperProfile()
    {
        CreateMap<Product, ProductDTo>()
            .ReverseMap();

        CreateMap<Offer, OfferDTo>()
          .ReverseMap();
    }
}
