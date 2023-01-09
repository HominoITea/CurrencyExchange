using Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Shared
{
    internal class CurrencyConfiguration : EntityTypeConfiguration<Currency>
    {
        public CurrencyConfiguration()
        {
            HasKey(x => x.Id);
            Property(x => x.Created).IsRequired().HasColumnType("datetime2");
            Property(x => x.Code).IsRequired().HasMaxLength(4);
            Property(x => x.FullName).IsRequired().HasMaxLength(100);
        }
    }
}
