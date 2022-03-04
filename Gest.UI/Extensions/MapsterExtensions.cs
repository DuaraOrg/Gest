using Gest.Core.Entities;
using Gest.UI._Features_.Stock.Components;
using Mapster;
using MapsterMapper;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Gest.UI.Extensions
{
    public static class MapsterExtensions
    {
        public static IServiceCollection AddMapster(this IServiceCollection services, Action<TypeAdapterConfig> options = null!)
        {
            var config = TypeAdapterConfig.GlobalSettings;
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            config.NewConfig<Article, ArticleModel>()
                .Map(dest => dest.SellingPricePerUnitOfMeasure, src => src.Price.SellingPricePerUnitOfMeasure)
                .Map(dest => dest.SellingPricePerConditionnement, src => src.Price.SellingPricePerConditionnement)
                .Map(dest => dest.BuyingPricePerUnitOfMeasure, src => src.Price.BuyingPricePerUnitOfMeasure)
                .Map(dest => dest.BuyingPricePerConditionnement, src => src.Price.BuyingPricePerConditionnement)
                .Map(dest => dest.StockMaximum, src => src.Stock.Maximum)
                .Map(dest => dest.StockMinimum, src => src.Stock.Minimum)
                .Map(dest => dest.StockQty, src => src.Stock.Qty)
                .Map(dest => dest.ConditionementName, src => src.Conditionnement.Name)
                .Map(dest => dest.ConditionnementQtyPerUnitOfMeasure, src => src.Conditionnement.QtyPerUnitOfMeasure);

            config.NewConfig<ArticleModel, Article>()
               .Map(dest => dest.Price.SellingPricePerUnitOfMeasure, src => src.SellingPricePerUnitOfMeasure)
               .Map(dest => dest.Price.SellingPricePerConditionnement, src => src.SellingPricePerConditionnement)
               .Map(dest => dest.Price.BuyingPricePerUnitOfMeasure, src => src.BuyingPricePerUnitOfMeasure)
               .Map(dest => dest.Price.BuyingPricePerConditionnement, src => src.BuyingPricePerConditionnement)
               .Map(dest => dest.Stock.Maximum, src => src.StockMaximum)
               .Map(dest => dest.Stock.Minimum, src => src.StockMinimum)
               .Map(dest => dest.Stock.Qty, src => src.StockQty)
               .Map(dest => dest.Conditionnement.Name, src => src.ConditionementName)
               .Map(dest => dest.Conditionnement.QtyPerUnitOfMeasure, src => src.ConditionnementQtyPerUnitOfMeasure);
#pragma warning restore CS8602 // Dereference of a possibly null reference.

            config.Scan(Assembly.GetAssembly(typeof(App))!);

            options?.Invoke(config);

            services.AddSingleton(config);
            services.AddScoped<IMapper, ServiceMapper>();

            return services;
        }
    }
}
