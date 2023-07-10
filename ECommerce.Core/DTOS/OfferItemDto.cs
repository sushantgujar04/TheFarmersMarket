namespace ECommerce.Core.DTOS;

public class OfferItemDto
{
    public Offer Offer { get; set; }
    public int OfferId { get; set; }
    public Product Product { get; set; }
    public int ProductId { get; set; }
    public decimal OfferPrice { get; set; }
}
