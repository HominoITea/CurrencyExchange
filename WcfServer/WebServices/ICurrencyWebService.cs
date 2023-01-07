using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace WcfServer.WebServices
{
    [ServiceContract]
    public interface ICurrencyWebService
    {
        [OperationContractAttribute(AsyncPattern = true)]
        Task<IReadOnlyList<T>> ListAllAsync<T>(IAsyncRepository<T> repository, int year, int month) where T : BaseEntity;
    }
}
