using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WcfServer.Models
{
    public class CurrencyDTO
    {
        public IReadOnlyList<CurrenciesPairRate> Rates { get; set; }
    }
}