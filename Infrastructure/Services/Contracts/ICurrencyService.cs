using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.Contracts
{
    [ServiceContract]
    public interface ICurrencyService : IService 
    {
        [OperationContract(AsyncPattern = true)]
        Task<IReadOnlyList<CurrenciesPairRate>> ListAllAsync();

        [OperationContract(AsyncPattern = true)]
        Task<IList<CurrenciesPairRate>> ListByPeriodAsync(int year, int month);
    }
}
