using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class CurrenciesPairRate : BaseEntity
    {
        public double Rate { get; set; }
        public long PairId { get; set; }    
        public CurrenciesPair Pair { get; set; }
    }
}