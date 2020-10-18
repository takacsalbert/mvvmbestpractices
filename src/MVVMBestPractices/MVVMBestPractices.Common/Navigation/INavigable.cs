using System.Threading.Tasks;

namespace MVVMBestPractices.Common.Navigation
{
    public interface INavigable
    {
        Task OnNavigatedTo(object parameter, NavigationMode mode);
        bool AllowGoBack();
        string PageName { get; set; }
    }
}
