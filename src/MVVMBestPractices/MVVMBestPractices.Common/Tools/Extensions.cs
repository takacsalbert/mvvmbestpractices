using GalaSoft.MvvmLight.Ioc;
using System;

namespace MVVMBestPractices.Common.Tools
{
    public static class Extensions
    {
        public static T GetNewInstance<T>(this SimpleIoc locator)
        {
            return locator.GetInstance<T>(Guid.NewGuid().ToString());
        }
    }
}
