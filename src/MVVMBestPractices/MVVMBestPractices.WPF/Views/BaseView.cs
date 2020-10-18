using GalaSoft.MvvmLight.Ioc;
using MVVMBestPractices.Common.Navigation;
using MVVMBestPractices.Common.Services;
using MVVMBestPractices.Common.ViewModels;
using MVVMBestPractices.WPF.Services;
using System.Windows.Controls;

namespace MVVMBestPractices.WPF.Views
{
    public class BaseView : UserControl
    {
        private readonly NavigationService _navigationService;

        public object LastNavigationParameter { get; set; }
        private VMBase ViewModel { get { return (VMBase)DataContext; } }

        public BaseView()
        {
            _navigationService = SimpleIoc.Default.GetInstance<INavigationService>() as NavigationService;
            Loaded += BaseView_Loaded;
        }

        private void BaseView_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            ViewModel.OnNavigatedTo(_navigationService.CurrentPageParameter, NavigationMode.New);
        }
    }
}
