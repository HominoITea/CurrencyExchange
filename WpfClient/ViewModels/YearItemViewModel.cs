using ClientShared.Handlers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfClient.Models;
using WpfClient.ViewModels.BaseComands;
using WpfClient.ViewModels.Interfaces;
using WpfClient.ViewModels.Shared;
using WpfClient.Views.Behavior;

namespace WpfClient.ViewModels
{
    public sealed class YearItemViewModel: BaseViewModel, IViewModel
    {
        public IMediator Mediator { get; set; }

        public ICommand SwitchToMonth { get; }        

        private YearItemModel _yearItem;

        private DateTime _selectedMonth;
        public DateTime SelectedMonth { 
            get => _selectedMonth;
            set {
                _selectedMonth = value;
                OnPropertyChanged(nameof(SelectedMonth));
                //Mediator.Send("DateChanged", SelectedMonth);
            }
        }

        public YearItemModel YearItem
        {
            get => _yearItem;
            set
            {
                _yearItem = value;
                OnPropertyChanged(nameof(YearItem));
            }
        }       

        public YearItemViewModel(IMediator mediator, int year, bool isSelected)
        {
            Mediator = mediator;
            SwitchToMonth = new RelayCommand<DateTime>(SwitchMonth);

            YearItem = new YearItemModel
            {
                Year = year,
                IsSelected = isSelected,
            };

            YearItem.FillMonthArray();
            //Mediator.Send("DateChanged", SelectedMonth);
        }
        private void SwitchMonth(DateTime date)
        {
            SelectedMonth = date;
        }
    }
}
