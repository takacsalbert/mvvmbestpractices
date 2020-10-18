using System;
using System.Collections.Generic;

namespace MVVMBestPractices.Common.Navigation
{
    public class Pages
    {
        public static string Main => nameof(Main);
        public static string Second => nameof(Second);

        public static Dictionary<string, Type> PageKeys { get; }

        static Pages()
        {
            PageKeys = new Dictionary<string, Type>();
        }
    }
}
