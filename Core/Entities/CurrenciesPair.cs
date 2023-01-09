using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class CurrenciesPair : BaseEntity
    {
        public long FromCurrencyId { get; set; }
        public Currency FromCurrency { get; set; }

        public long ToCurrencyId { get; set; }
        public Currency ToCurrency { get; set; }        
    }
}
