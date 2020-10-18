using MVVMBestPractices.Common.Navigation;
using MVVMBestPractices.Common.Services;
using MVVMBestPractices.WPF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace MVVMBestPractices.WPF.Services
{
    public class NavigationService : INavigationService
    {
        private Stack<BaseView> _backStack { get; } = new Stack<BaseView>();

        public ContentControl Content { get; private set; }
        public string CurrentPageKey { get; set; }
        public object CurrentPageParameter { get; set; }

        public void Initialize(ContentControl content)
        {
            Content = content;
        }

        public void Navigate(string pageKey, object parameter = null)
        {
            if (CurrentPageKey == pageKey && CurrentPageParameter == parameter)
                return;

            CurrentPageKey = pageKey;
            CurrentPageParameter = parameter;
            if (Pages.PageKeys.ContainsKey(pageKey))
            {
                var type = Pages.PageKeys[pageKey];
                var view = (BaseView)Activator.CreateInstance(type);
                view.LastNavigationParameter = CurrentPageParameter;
                Content.Content = view;
                _backStack.Push(view);
            }
            else
                System.Diagnostics.Debug.WriteLine("Page not found in PageKeys!");
        }

        public void GoBack()
        {
            if (!CanGoBack())
                return;

            RemoveBackEntry();

            var previusPage = _backStack.Peek();
            CurrentPageKey = Pages.PageKeys.FirstOrDefault(x => x.Value == previusPage.GetType()).Key;
            CurrentPageParameter = previusPage.LastNavigationParameter;
            Content.Content = previusPage;
        }

        public bool CanGoBack()
        {
            return _backStack.Count > 1;
        }

        public void ClearNavigationHistoryButFirstPage()
        {
            RemoveBackEntry(_backStack.Count - 1);
        }

        private void RemoveBackEntry(int entries = 1)
        {
            var entriesToRemove = Math.Min(entries, _backStack.Count);
            var iEnd = _backStack.Count - 1 - entriesToRemove;

            for (var i = _backStack.Count - 1; i > iEnd; i--)
            {
                _backStack.Pop();
            }
        }
    }
}
