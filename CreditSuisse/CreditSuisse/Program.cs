using Application.Aplication;
using Application.InterfaceAplication;
using Domain.InterfaceService;
using Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CreditSuisse
{
     class Program
    {
        
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();

            var iAplicationTrade = (IAplicationTrade[])serviceProvider.GetServices(typeof(IAplicationTrade));

            iAplicationTrade[0].Classify();

        }
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ITradeService, TradeService>();
            services.AddTransient<IAplicationTrade, AplicationTrade>();
        }
    }
}
