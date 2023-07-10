using ECommerce.Core.Interfaces.Services;
using ECommerce.Core.Services;

namespace ECommerce.Infrastrucure;

public static class ModuleInfrastructureDependencies
{
    public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
    {
        #region Dependency Injection
        services.AddTransient<IUnitOfWork, UnitOfWork>();

        //Repository
        services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddTransient<IProductRepository, ProductRepository>();
        services.AddTransient<IOfferRepository, OfferRepository>();
        services.AddTransient<IProductsRepository, ProductsRepository>();
        services.AddTransient<IOfferItemRepository, OfferItemRepository>();
        services.AddTransient<IProductsServices, ProductsServices>();
        //services.AddTransient<IBasketRepository, BasketRepository>();

        //Services
        services.AddTransient<IProductServices, ProductServices>();
        services.AddTransient<IOfferServices, OfferServices>();
        services.AddTransient<IOfferItemService, OfferItemService>();


        #endregion

        #region Add Fluent Validation

        //builder.Services
        //    .AddMvc(options => options.Filters.Add<ValidationFilter>())
        //    .AddFluentValidation(options => options.RegisterValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));

        //services.AddFluentValidation(options =>
        //{
        //    options.RegisterValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
        //});

        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        #endregion

        return services;
    }

}
