using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClient.Models
{
    public sealed class CurrencyRatesModel
    {
        public IEnumerable<CurrenciesPairRate> CurrencyRates { get; set; }
    }
}
