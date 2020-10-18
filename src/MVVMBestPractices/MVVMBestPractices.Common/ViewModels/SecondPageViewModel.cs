using GalaSoft.MvvmLight.Command;
using MVVMBestPractices.Common.Navigation;
using MVVMBestPractices.Common.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMBestPractices.Common.ViewModels
{
    public class SecondPageViewModel : VMBase
    {
        private readonly INavigationService _navigationService;

        private string _DateString;
        public string DateString
        {
            get { return _DateString; }
            set { Set(ref _DateString, value); }
        }

        private ICommand _GoBackCommand;

        public ICommand GoBackCommand { get { return _GoBackCommand ?? (_GoBackCommand = new RelayCommand(() => GoBack())); } }

        public SecondPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override Task OnNavigatedTo(object parameter, NavigationMode mode)
        {
            if (parameter != null && parameter is string)
                DateString = parameter.ToString();

            PageName = $"Second page - {DateString}";

            return Task.CompletedTask;
        }

        private void GoBack()
        {
            _navigationService.GoBack();
        }
    }
}
