using Autofac;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Services;
using Infrastructure.Services.Contracts;
using System.Reflection;

namespace WcfServer
{
    public class Bootstrap
    {
        public static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();

            AddContext(ref builder);
            AddServices(ref builder);

            return builder.Build();
        }

        private static void AddContext(ref ContainerBuilder builder)
        {
            builder.RegisterType<CurrencyContext>();
            builder.RegisterType<CommandData<CurrenciesPairRate>>().AsImplementedInterfaces();
            builder.RegisterType<QueryData<CurrenciesPairRate>>().AsImplementedInterfaces();
        }

        private static void AddServices(ref ContainerBuilder builder)
        {
            builder.RegisterType<CurrencyService>().Named<object>("CurrencyService");
        }
    }
}