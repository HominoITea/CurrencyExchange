using Core.Entities;
using System.Collections.Generic;
using System.Data.Entity;


namespace Infrastructure.Data.Shared
{
    public class DatabaseInitializer : CreateDatabaseIfNotExists<CurrencyContext>
    {
        protected override void Seed(CurrencyContext context)
        {
            base.Seed(context);

            context.Currencies.AddRange(Currencies);
            context.CurrenciesRates.AddRange(CurrencyRates);
            context.CurrenciesPair.AddRange(CurrencyPairs);

            context.SaveChanges();
        }

        public List<Currency> Currencies => new List<Currency>()
            {
                new Currency
                {
                    Id = 1, Code = "RUB", FullName = "Российский рубль", Created = System.DateTime.Now
                },
                new Currency
                {
                    Id = 2, Code = "USD", FullName = "Доллар США", Created = System.DateTime.Now
                },
                new Currency
                {
                    Id = 3, Code = "EUR", FullName = "Евро", Created = System.DateTime.Now
                },
                new Currency
                {
                    Id = 4, Code = "KZT", FullName = "Тенге", Created = System.DateTime.Now
                }
            };

        public List<CurrenciesPairRate> CurrencyRates => new List<CurrenciesPairRate>()
            {
                new CurrenciesPairRate
                {
                    Id = 1, PairId = 1, Rate = 76.10, Created = System.DateTime.Now
                },
                new CurrenciesPairRate
                {
                    Id = 2, PairId = 2, Rate = 77.56, Created = System.DateTime.Now
                },
                new CurrenciesPairRate
                {
                    Id = 3, PairId = 3, Rate = 0.15, Created = System.DateTime.Now
                }
            };
        public List<CurrenciesPair> CurrencyPairs  => new List<CurrenciesPair>()
            {
                new CurrenciesPair
                {
                    Id = 1, FromCurrencyId = 2, ToCurrencyId = 1, Created = System.DateTime.Now
                },
                new CurrenciesPair
                {
                    Id = 2, FromCurrencyId = 3, ToCurrencyId = 1, Created = System.DateTime.Now
                }, 
                new CurrenciesPair
                {
                    Id = 3, FromCurrencyId = 4, ToCurrencyId = 1, Created = System.DateTime.Now
                }
            };
        
    }
}
