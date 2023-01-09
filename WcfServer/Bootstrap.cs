using Autofac;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Services;
using Infrastructure.Services.Contracts;

namespace WcfServer
{
    public class Bootstrap
    {
        public static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            
            builder.RegisterType<CurrencyContext>();
            builder.RegisterType<Repository<CurrenciesPairRate>>().AsImplementedInterfaces();
            builder.RegisterType<CurrencyService>().Named<object>("CurrencyService");

            return builder.Build();
        }
    }
}