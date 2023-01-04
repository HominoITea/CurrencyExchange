using System;
using System.Data.Entity;
using System.Linq;
using WcfServer.Entities;

namespace WcfServer.Models
{
    public class CurrencyModel : DbContext
    {
        // Контекст настроен для использования строки подключения "CurrencyModel" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "WcfServer.CurrencyModel" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "CurrencyModel" 
        // в файле конфигурации приложения.
        DbSet<Currency> Currencies { get; set; }
        DbSet<CurrencyRate> CurrenciesRates { get; set; }
        public CurrencyModel() : base("name=CurrencyModel")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}