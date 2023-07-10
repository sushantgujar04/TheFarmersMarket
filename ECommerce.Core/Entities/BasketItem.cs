namespace ECommerce.Core.Entities;

public class BasketItem
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public Offer Offer { get; set; }
}