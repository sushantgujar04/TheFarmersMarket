namespace ECommerce.Core.Entities;

public class Product : BaseEntity
{
    public string Name { get; set; }
    public string Code { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public CurrencyCode CurrencyCode { get; set; }

    public List<OfferItem> OfferItems { get; set; }

}
