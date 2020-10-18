using GalaSoft.MvvmLight.Ioc;
using MVVMBestPractices.Common.Navigation;
using MVVMBestPractices.Common.Services;
using MVVMBestPractices.WPF.Services;
using System.Windows;

namespace MVVMBestPractices.WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var navigationService = SimpleIoc.Default.GetInstance<INavigationService>() as NavigationService;
            navigationService.Initialize(MainContent);
            navigationService.Navigate(Pages.Main);
        }
    }
}
