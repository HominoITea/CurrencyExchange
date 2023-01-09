using Autofac;
using ClientShared.Handlers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;
using WpfClient.Services;
using WpfClient.ViewModels;
using WpfClient.ViewModels.Interfaces;

namespace WpfClient
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ContainerBuilder _builder;
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            _builder = new ContainerBuilder();
            AddViewModels();
            AddMiddliware();
            AddServices();

            var container = _builder.Build();
            var view = new MainWindow
            {
                DataContext = container.Resolve<IMainViewModel>(),
            };
            view.Show();
        }

        private void AddViewModels()
        {
            _builder.RegisterType<YearPickerViewModel>().AsSelf().AsImplementedInterfaces();            
            _builder.RegisterType<MainViewModel>().AsSelf().AsImplementedInterfaces();
            _builder.RegisterType<DataGridViewModel>().AsSelf().AsImplementedInterfaces();
        }

        private void AddMiddliware()
        {
            _builder.RegisterType<Mediator>().As<IMediator>();
        }

        private void AddServices()
        {
            _builder.RegisterType<CurrencyDataService>().AsImplementedInterfaces(); 
        }
    }
}
