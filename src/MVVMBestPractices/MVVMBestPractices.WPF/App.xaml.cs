using GalaSoft.MvvmLight.Ioc;
using MVVMBestPractices.Common.Navigation;
using MVVMBestPractices.Common.Services;
using MVVMBestPractices.Common.ViewModels;
using MVVMBestPractices.WPF.Navigation;
using MVVMBestPractices.WPF.Services;
using System.Windows;

namespace MVVMBestPractices.WPF
{
    public partial class App : Application
    {
        public App()
        {
            Initialize();
        }

        private void Initialize()
        {
            SimpleIoc.Default.Register<INavigationService, NavigationService>();
            SimpleIoc.Default.Register<IPageAssociation, PageAssociation>();
            SimpleIoc.Default.Register<MainPageViewModel>();
            SimpleIoc.Default.Register<SecondPageViewModel>();

            AssociatePages();
        }

        private void AssociatePages()
        {
            var pageAssociation = SimpleIoc.Default.GetInstance<IPageAssociation>();
            pageAssociation.AssociatePages(Pages.PageKeys);
        }
    }
}
