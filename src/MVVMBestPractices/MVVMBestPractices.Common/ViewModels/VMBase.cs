using GalaSoft.MvvmLight;
using MVVMBestPractices.Common.Navigation;
using System.Threading.Tasks;

namespace MVVMBestPractices.Common.ViewModels
{
    public class VMBase : ViewModelBase, INavigable
    {
        private string _PageName;
        public string PageName
        {
            get { return _PageName; }
            set { Set(ref _PageName, value); }
        }

        private bool _IsBusy;
        public bool IsBusy
        {
            get { return _IsBusy; }
            set { Set(ref _IsBusy, value); }
        }

        public virtual Task OnNavigatedTo(object parameter, NavigationMode mode)
        {
            return Task.CompletedTask;
        }

        /// <summary>
        /// Override and return false to prevent going back.
        /// </summary>
        public virtual bool AllowGoBack()
        {
            return true;
        }
    }
}
