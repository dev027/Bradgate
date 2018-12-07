using System;
using Humanizer;

namespace Bradgate.General.Extensions.DateTimeExtensions
{
    public static class DateTimeExtensions
    {
        // ReSharper disable once InconsistentNaming
        public static string ToDD_MMM_YYYY(this DateTime x) => x.Day.Ordinalize() + x.ToString(" MMM yyyy");
    }
}