namespace ECommerce.Core.DTOS;

public class OfferDTo
{
    public int Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public int Limit { get; set; }
    public bool IsActive { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public List<OfferItem> OfferItems { get; set; }
    public int MinimumQty { get; set; }
}
