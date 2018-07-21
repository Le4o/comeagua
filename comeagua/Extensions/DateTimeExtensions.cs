using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramNet.Service.Extensions
{
    public static class DateTimeExtensions
    {
        public static long ToUnixTimestamp(this DateTime dateTime)
        {
            var origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            var diff = dateTime - origin;
            return (long)Math.Floor(diff.TotalSeconds);
        }

        public static DateTime UnixTimeStampToDateTime(this long unixTimeStamp)
        {
            var dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        public static DateTime UnixTimeStampToDateTime(this string unixTimeStamp)
        {
            var date = long.Parse(unixTimeStamp);
            return date.UnixTimeStampToDateTime();
        }
    }
}
