using Core.Entities;
using Core.Interfaces;
using Infrastructure.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class CurrencyService : ICurrencyService
    {
        private readonly IAsyncRepository<CurrenciesPairRate> _repository;
        private readonly IQueryData<CurrenciesPairRate> _query;
        private readonly ICommandData<CurrenciesPairRate> _command;

        public CurrencyService(ICommandData<CurrenciesPairRate> command, IQueryData<CurrenciesPairRate> query)
        {
            _command = command;
            _query = query;
        }

        public async Task<IReadOnlyList<CurrenciesPairRate>> ListAllAsync()
        {
            return await _query.ListAllAsync();
        }

        public async Task<IDictionary<DateTime, IList<CurrenciesPairRate>>> ListByPeriodAsync(int year, int month)
        {
            var ratesByPeriod = await _query.ListByPeriodAsync(year, month);
            var ratesGroupedByDate = new Dictionary<DateTime, IList<CurrenciesPairRate>>();

            foreach (var item in ratesByPeriod.GroupBy(x => x.Created.Date).OrderBy(x => x.Key))
            {
                ratesGroupedByDate.Add(item.Key, item.ToList());
            }
            
            return ratesGroupedByDate;
        }
    }
}
