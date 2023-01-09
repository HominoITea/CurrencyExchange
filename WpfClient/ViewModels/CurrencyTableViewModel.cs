using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfClient.ViewModels.Shared;

namespace WpfClient.ViewModels
{
    public sealed class CurrencyTableViewModel : BaseViewModel
    {
        private DateTime _dateTime;
        public DateTime SelectedDateTime
        {
            get => _dateTime;
            set
            {
                _dateTime = value;
                OnPropertyChanged(nameof(SelectedDateTime));
            }
        }
    }
}
