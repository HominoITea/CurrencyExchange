using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class CurrenciesPairRates 
    {
        public IList<IGrouping<DateTime, CurrenciesPairRate>> RatesByPeriod { get; set; }
    }
}
