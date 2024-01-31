using System;
using System.Globalization;

namespace PresentationLayer
{
    public class DateTimeHelper
    {
        public DateTimeHelper()
        {
        }

        public static string GetCurrentPersianDate()
        {
            PersianCalendar calender = new PersianCalendar();

            string year = calender.GetYear(DateTime.Now).ToString();
            string month = calender.GetMonth(DateTime.Now).ToString();
            month = (month.Length == 1) ? "0" + month : month;
            string day = calender.GetDayOfMonth(DateTime.Now).ToString();
            day = (day.Length == 1) ? "0" + day : day;
            return year + "/" + month + "/" + day;
        }

        public static string GetCurrentTime()
        {
            string time = DateTime.Now.TimeOfDay.ToString();
            return time.Substring(0, time.IndexOf('.'));
        }
    }
}
