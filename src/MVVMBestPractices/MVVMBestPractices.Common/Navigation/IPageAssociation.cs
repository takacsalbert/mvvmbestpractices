using System;
using System.Collections.Generic;

namespace MVVMBestPractices.Common.Navigation
{
    public interface IPageAssociation
    {
        void AssociatePages(Dictionary<string, Type> pageKeys);
    }
}
