using System;

namespace Stickers.Core.Utilities
{
    public static class DateUtility
    {
        public static DateTime GetZeroTimeDate(DateTime time)
        {
            return new DateTime(time.Year, time.Month, time.Day);
        }

        public static DateTime GetAlmostMidnightDate(DateTime time)
        {
            return new DateTime(time.Year, time.Month, time.Day, 23, 59, 59);
        }
    }
}
