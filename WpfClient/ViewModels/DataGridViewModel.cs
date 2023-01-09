using ClientShared.Handlers;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Markup;
using WpfClient.Models;
using WpfClient.Services.Intefaces;
using WpfClient.ViewModels.Interfaces;
using WpfClient.WebServices;

namespace WpfClient.ViewModels
{
    public sealed class DataGridViewModel: IDataGridViewModel
    {
        private IMediator _mediator;

        private Dictionary<string, CurrencyRatesModel> _rates;
        private ListCollectionView _listCollection;

        private List<CurrenciesPairRate> _dataStream;
        public List<CurrenciesPairRate> Data
        {
            get
            {
                _dataStream = _service.GetCurrenciesPairRates(2023, 1).GetAwaiter().GetResult();
                return _dataStream;
            }   
        }

        private ICurrencyDataService _service;

        public DataGridViewModel(IMediator mediator, ICurrencyDataService service) 
        {
            _mediator = mediator;
            _service = service;
        }
    }
}
