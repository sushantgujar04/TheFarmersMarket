using ECommerce.Core.Entities;
using System.Text.Json;

namespace ECommerce.Infrastrucure.Data;

public class StoreContextSeed
{
    public static async Task SeedAsync(ApplicationDBContext context)
    {
        try
        {


            if (!context.CurrencyCodes.Any())
            {
                var currencyCodesData = File.ReadAllText("../ECommerce.Infrastrucure/Data/SeedData/Currency.json");
                var currencyCodes = JsonSerializer.Deserialize<List<CurrencyCode>>(currencyCodesData);
                context.CurrencyCodes.AddRange(currencyCodes);
                context.SaveChanges();
            }
            if (!context.Products.Any())
            {
                var productsData = File.ReadAllText("../ECommerce.Infrastrucure/Data/SeedData/products.json");
                var products = JsonSerializer.Deserialize<List<Product>>(productsData);
                context.Products.AddRange(products);
                context.SaveChanges();

            }
            if (!context.Offers.Any())
            {
                var offersData = File.ReadAllText("../ECommerce.Infrastrucure/Data/SeedData/offer.json");
                var offers = JsonSerializer.Deserialize<List<Offer>>(offersData);
                context.Offers.AddRange(offers);
                context.SaveChanges();
            }
            if (!context.OfferItems.Any())
            {
                var offerItemsData = File.ReadAllText("../ECommerce.Infrastrucure/Data/SeedData/offeritem.json");
                var offerItems = JsonSerializer.Deserialize<List<OfferItem>>(offerItemsData);
                context.OfferItems.AddRange(offerItems);
                context.SaveChanges();
            }

            if (context.ChangeTracker.HasChanges()) await context.SaveChangesAsync();
        }
        catch (Exception ex)
        {

            throw;
        }

    }
}
