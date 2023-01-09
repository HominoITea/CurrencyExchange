using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClient.Services.Intefaces
{
    public interface ICurrencyDataService
    {
        Task<List<CurrenciesPairRate>> GetCurrenciesPairRates(int year, int month);
    }
}
