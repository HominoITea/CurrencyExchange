using Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Shared
{
    internal class CurrencyPairConfiguration : EntityTypeConfiguration<CurrenciesPair>
    {
        public CurrencyPairConfiguration() { 
            
            HasKey(x => x.Id);
            Property(x => x.Created).IsRequired().HasColumnType("datetime2");
        }
    }
}
