using Core.Entities;
using Core.Interfaces;
using Infrastructure.Services.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class CurrencyService : ICurrencyService
    {
        private readonly IAsyncRepository<CurrenciesPairRate> _repository;

        public CurrencyService(IAsyncRepository<CurrenciesPairRate> repository)
        {
            _repository = repository;
        }

        public async Task<IReadOnlyList<CurrenciesPairRate>> ListAllAsync()
        {
            return await _repository.ListAllAsync();
        }

        public async Task<IList<CurrenciesPairRate>> ListByPeriodAsync(int year, int month)
        {
            var result = await _repository.ListByPeriodAsync(year, month);
            return result.ToList();
        }
    }
}
