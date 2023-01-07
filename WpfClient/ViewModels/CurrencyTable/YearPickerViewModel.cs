using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using WpfClient.ViewModels.BaseComands;

namespace WpfClient.ViewModels.CurrencyTable
{
    public sealed class YearPickerViewModel : BaseViewModel
    {
        private const int _yearsToDisplay = 5;
        public ICommand UpdateCollection { get; }
        public ICommand SwitchToMonth { get; }
        public ObservableCollection<YearItemViewModel> _items;
        public ObservableCollection<YearItemViewModel> Items
        {
            get
            {
                return _items;
            }
            private set
            {
                _items = value;
                OnPropertyChanged(nameof(Items));
            }
        }

        public YearPickerViewModel()
        {
            UpdateCollection = new RelayCommand<int>(Update);
            SwitchToMonth = new RelayCommand<DateTime>(ChangeMonth);
            Items = CreateCollection();
        }

        private void Update(int yearOffset)
        {
            Items = CreateCollection(yearOffset);
        }

        private ObservableCollection<YearItemViewModel> CreateCollection(int yearOffset = 0)
        {
            var year = Items is null
                ? DateTime.Now.Year 
                : Items[0].YearItem.Year + yearOffset;

            var items = new ObservableCollection<YearItemViewModel>();
            for (int i = year; i < year + _yearsToDisplay; i++)
            {
                items.Add(new YearItemViewModel(i));
            }

            items
                .First()
                .YearItem
                .IsSelected = true;
            
            return items;
        }

        private void ChangeMonth(DateTime date)
        {

        }
    }
}
