using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfClient.Models.CurrencyTable;

namespace WpfClient.ViewModels.CurrencyTable
{
    public sealed class YearItemViewModel: BaseViewModel
    {
        private YearItemModel _yearItem;
        public YearItemModel YearItem
        {
            get => _yearItem;
            set
            {
                _yearItem = value;
                OnPropertyChanged(nameof(YearItem));
            }
        }

        public YearItemViewModel(int year)
        {
            YearItem = new YearItemModel
            {
                Year = year
            };
        }
    }
}
