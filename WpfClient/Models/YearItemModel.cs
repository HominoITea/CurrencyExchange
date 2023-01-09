using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClient.Models
{
    public class YearItemModel
    {
        private const int monthInYear = 12;
        private const string quarterText = "квартал";
        public ObservableCollection<MonthItemModel> MonthItems { get; private set; }
        public int Year { get; internal set; }

        public bool IsSelected { get; set; }

        internal void FillMonthArray()
        {
            MonthItems = new ObservableCollection<MonthItemModel>();
            for (int i = 0; i < monthInYear; i++)
            {
                MonthItems.Add(new MonthItemModel
                {
                    MonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(i + 1),
                    Quarter = $"{GetQuarter(i)} {quarterText}",
                    TargetDate = new DateTime(Year, i+1, 1)
                });
            }
        }

        private int GetQuarter(int month) => (month / 3) + 1;
    }
}
