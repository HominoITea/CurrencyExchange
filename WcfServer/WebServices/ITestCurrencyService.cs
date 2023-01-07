using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServer.WebServices
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "ITestCurrencyService" в коде и файле конфигурации.
    [ServiceContract]
    public interface ITestCurrencyService
    {
        [OperationContract]
        void DoWork();
    }
}
