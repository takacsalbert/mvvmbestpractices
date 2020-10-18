using GalaSoft.MvvmLight.Command;
using MVVMBestPractices.Common.Navigation;
using MVVMBestPractices.Common.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMBestPractices.Common.ViewModels
{
    public class MainPageViewModel : VMBase
    {
        private readonly INavigationService _navigationService;

        private ICommand _GoToSecondPageCommand;

        public ICommand GoToSecondPageCommand { get { return _GoToSecondPageCommand ?? (_GoToSecondPageCommand = new RelayCommand(() => GoToSecondPage())); } }

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override async Task OnNavigatedTo(object parameter, NavigationMode mode)
        {
            // add a little delay
            await Task.Delay(1000);
            PageName = "Main page";
        }

        private void GoToSecondPage()
        {
            _navigationService.Navigate(Pages.Second, DateTime.Now.ToString());
        }
    }
}
