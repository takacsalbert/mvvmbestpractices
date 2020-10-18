using GalaSoft.MvvmLight.Ioc;
using MVVMBestPractices.Common.ViewModels;

namespace MVVMBestPractices.WPF.Views
{
    public partial class MainView : BaseView
    {
        public MainPageViewModel VM => DataContext as MainPageViewModel;

        public MainView()
        {
            InitializeComponent();
            DataContext = SimpleIoc.Default.GetInstance<MainPageViewModel>();
        }
    }
}
