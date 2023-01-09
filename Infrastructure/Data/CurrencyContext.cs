using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data.Shared;

namespace Infrastructure.Data
{
    public class CurrencyContext : DbContext
    {
        public DbSet<Currency> Currencies { get; set; }
        
        public DbSet<CurrenciesPair> CurrenciesPair { get; set; }

        public DbSet<CurrenciesPairRate> CurrenciesRates { get; set; }

        public CurrencyContext() : base("name=CurrencyContext")
        {
            Database.SetInitializer(new DatabaseInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new CurrencyConfiguration());
            modelBuilder.Configurations.Add(new CurrencyPairConfiguration());
            modelBuilder.Configurations.Add(new CurrencyRateConfiguration());

            

            modelBuilder
              .Entity<CurrenciesPairRate>()
              .HasRequired(c => c.Pair)
              .WithMany()
              .HasForeignKey(c => c.PairId)
              .WillCascadeOnDelete(true);


            modelBuilder
              .Entity<CurrenciesPair>()
              .HasRequired(c => c.ToCurrency)
              .WithMany()
              .HasForeignKey(c => c.ToCurrencyId)
              .WillCascadeOnDelete(false);

            modelBuilder
              .Entity<CurrenciesPair>()
              .HasRequired(c => c.FromCurrency)
              .WithMany()
              .HasForeignKey(c => c.FromCurrencyId)
              .WillCascadeOnDelete(false);
        }
    }
}