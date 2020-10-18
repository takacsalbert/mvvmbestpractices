namespace MVVMBestPractices.Common.Services
{
    public interface INavigationService
    {
        string CurrentPageKey { get; set; }
        object CurrentPageParameter { get; set; }
        void Navigate(string pageKey, object parameter = null);
        void GoBack();
        bool CanGoBack();
        void ClearNavigationHistoryButFirstPage();
    }
}
