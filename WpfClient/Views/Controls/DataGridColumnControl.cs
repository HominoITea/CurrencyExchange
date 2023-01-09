
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace WpfClient.Views.Controls
{
    internal sealed class DataGridColumnControl : DataGridTemplateColumn
    {
        public string ColumnName { get; private set; }
        public DataGridColumnControl(string columnName)
        {
            ColumnName = columnName;
        }

        protected override FrameworkElement GenerateElement(DataGridCell cell, object dataItem)
        {
            var content = (ContentPresenter) base.GenerateElement(cell, dataItem);
            var binding = new Binding(ColumnName);

            BindingOperations.SetBinding(content, ContentPresenter.ContentProperty, binding);
            return content;
        }
    }
}
