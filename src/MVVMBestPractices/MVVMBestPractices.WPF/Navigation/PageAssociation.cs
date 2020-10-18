using MVVMBestPractices.Common.Navigation;
using MVVMBestPractices.WPF.Views;
using System;
using System.Collections.Generic;

namespace MVVMBestPractices.WPF.Navigation
{
    public class PageAssociation : IPageAssociation
    {
        public void AssociatePages(Dictionary<string, Type> pageKeys)
        {
            pageKeys.Add(Pages.Main, typeof(MainView));
            pageKeys.Add(Pages.Second, typeof(SecondView));
        }
    }
}
