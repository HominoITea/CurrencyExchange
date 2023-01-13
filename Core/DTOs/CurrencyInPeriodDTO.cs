using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WcfServer.Models
{
    public class CurrencyInPeriodDTO
    {
        public DateTime CreatedAt { get; set; }

        public IList<CurrenciesPairRate> Rates { get; set; }
    }
}