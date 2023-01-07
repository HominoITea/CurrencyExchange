using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;

namespace WcfServer.WebServices
{
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы CurrencyWebService.svc или CurrencyWebService.svc.cs в обозревателе решений и начните отладку.
    public class CurrencyWebService : ICurrencyWebService
    {
        
        public async Task<IReadOnlyList<T>> ListAllAsync<T>(IAsyncRepository<T> repository, int year, int month) where T: BaseEntity
        {
            return await repository.ListByDateAsync(year, month);
        }
    }
}
