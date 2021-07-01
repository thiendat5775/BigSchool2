using System;
using System.Globalization;

namespace BigSchool2.ViewModels
{
    internal class DataTime
    {
        public static DataTime Now { get; internal set; }

        internal static object TryParseExact(string v1, string v2, CultureInfo currentCulture, object none, out DataTime dataTime)
        {
            throw new NotImplementedException();
        }
    }
}