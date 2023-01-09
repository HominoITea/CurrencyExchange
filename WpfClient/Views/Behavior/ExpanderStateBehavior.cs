using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using ClientShared.Handlers;
using Microsoft.Xaml.Behaviors;
namespace WpfClient.Views.Behavior
{
    public class ExpanderStateBehavior : Behavior<Expander>
    {
        private bool _isFocused;

        public IMediator Mediator {
            get => (IMediator)GetValue(MediatorProperty);
            set => SetValue(MediatorProperty, value);
        }

        public static readonly DependencyProperty MediatorProperty = DependencyProperty.Register(
            nameof(Mediator),
            typeof(IMediator),
            typeof(ExpanderStateBehavior),
            new PropertyMetadata(default(IMediator)));

        public bool IsExpanded
        {
            get => (bool)GetValue(IsExpandedProperty);
            set => SetValue(IsExpandedProperty, value);
        }

        public static readonly DependencyProperty IsExpandedProperty = DependencyProperty.Register(
            nameof(IsExpanded),
            typeof(bool),
            typeof(ExpanderStateBehavior),
            new PropertyMetadata(default(bool)));


        protected override void OnAttached()
        {
            base.OnAttached();

            _isFocused = AssociatedObject.IsExpanded;

            Mediator.Register("Expander", Collapse);
            AssociatedObject.Expanded += Expanded;
            AssociatedObject.Collapsed += Collapsed;
        }

        private void Collapsed(object sender, RoutedEventArgs e)
        {
            if (_isFocused)
            {
                AssociatedObject.IsExpanded = true;
            }            
        }

        private void Expanded(object sender, RoutedEventArgs e)
        {            
            if (AssociatedObject.IsExpanded)
            {
                Mediator.Send("Expander", AssociatedObject.Header);
            }
            AssociatedObject.IsExpanded = true;
            _isFocused = true;
        }        

        private void Collapse(object _state)
        {
            if (!AssociatedObject.Header.Equals((int)_state) && AssociatedObject.IsExpanded)
            {
                _isFocused = false;
                AssociatedObject.IsExpanded = false;
            } 
        }
    }
}
