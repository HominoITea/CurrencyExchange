using ClientShared.Handlers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Documents;
using System.Windows.Input;
using WpfClient.Models;
using WpfClient.ViewModels.BaseComands;
using WpfClient.ViewModels.Interfaces;
using WpfClient.ViewModels.Shared;

namespace WpfClient.ViewModels
{
    public sealed class YearPickerViewModel : BaseViewModel, IYearPickerViewModel
    {
        private const int _yearsToDisplay = 5;

        private IMediator _mediator;

        public ICommand UpdateCollection { get; }

        private YearItemModel _selected;
        public YearItemModel Selected { 
            get => _selected; 
            private set
            {
                _selected = value;
                OnPropertyChanged(nameof(Selected));
            }
        }

        public ObservableCollection<YearItemViewModel> _items;
        public ObservableCollection<YearItemViewModel> Items
        {
            get =>_items;
            private set
            {
                _items = value;
                OnPropertyChanged(nameof(Items));
            }
        }

        public YearPickerViewModel(IMediator mediator)
        {
            _mediator = mediator;
            UpdateCollection = new RelayCommand<int>(Update);
            Items = CreateCollection();
        }        

        private ObservableCollection<YearItemViewModel> CreateCollection(int yearOffset = 0)
        {
            var initialYear = Items is null
                ? DateTime.Now.Year 
                : Items[0].YearItem.Year + yearOffset;

            var items = new ObservableCollection<YearItemViewModel>();

            for (int i = initialYear; i < initialYear + _yearsToDisplay; i++)
            {
                items.Add(new YearItemViewModel(_mediator, i, i == initialYear));
            }            
            return items;
        }

        private void Update(int yearOffset)
        {
            Items = CreateCollection(yearOffset);
        }
    }
}
