using ClientShared.Handlers;
using Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using WpfClient.Services.Intefaces;
using WpfClient.WebServices;

namespace WpfClient.Services
{
    public class CurrencyDataService : ICurrencyDataService
    {
        private IMediator _mediator;        

        public CurrencyDataService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<List<CurrenciesPairRate>> GetCurrenciesPairRates(int year, int month)
        {
            var data = new CurrencyServiceClient();
            return await data.ListByPeriodAsync(year, month);
        }
    }
}
