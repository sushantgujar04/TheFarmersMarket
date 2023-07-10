namespace ECommerce.Infrastrucure.Data;

public class ApplicationDBContext : DbContext
{

    public ApplicationDBContext()
    {

    }
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
    {

    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)

        => options.UseSqlServer("Server=GS-5682;Database=FarmersMarket;Trusted_Connection=True;Encrypt=False;MultipleActiveResultSets=true");


    public DbSet<Product> Products { get; set; }
    public DbSet<Offer> Offers { get; set; }
    public DbSet<OfferItem> OfferItems { get; set; }
    public DbSet<CurrencyCode> CurrencyCodes { get; set; }
    public DbSet<BasketItem> BasketItems { get; set; }
    public DbSet<CustomerBasket> CustomerBaskets { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<OfferItem>()
            .HasOne(m => m.Offer)
            .WithMany(am => am.OfferItems)
            .HasForeignKey(m => m.OfferId);

        modelBuilder.Entity<OfferItem>()
           .HasOne(m => m.Product)
           .WithMany(am => am.OfferItems)
           .HasForeignKey(m => m.ProductId);

        base.OnModelCreating(modelBuilder);
    }
}
