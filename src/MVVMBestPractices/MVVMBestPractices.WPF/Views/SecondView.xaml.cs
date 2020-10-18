using GalaSoft.MvvmLight.Ioc;
using MVVMBestPractices.Common.Tools;
using MVVMBestPractices.Common.ViewModels;

namespace MVVMBestPractices.WPF.Views
{
    public partial class SecondView : BaseView
    {
        public SecondPageViewModel VM => DataContext as SecondPageViewModel;

        public SecondView()
        {
            InitializeComponent();
            DataContext = SimpleIoc.Default.GetNewInstance<SecondPageViewModel>();
        }
    }
}
