using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServer.WebServices
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "TestCurrencyService" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы TestCurrencyService.svc или TestCurrencyService.svc.cs в обозревателе решений и начните отладку.
    public class TestCurrencyService : ITestCurrencyService
    {
        public void DoWork()
        {
        }
    }
}
