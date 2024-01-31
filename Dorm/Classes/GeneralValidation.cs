using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace PresentationLayer
{
    public class GeneralValidation
    {
        public GeneralValidation()
        { 
        }

        public static bool CheckIp(string ip)
        {
            int num;
            string[] strArray = new string[ip.Length];
            for (num = 0; num < strArray.Length; num++)
            {
                strArray[num] = ip.Substring(num, 1);
            }
            try
            {
                for (num = 0; num < ip.Length; num++)
                {
                    if (strArray[num] != ".")
                    {
                        Convert.ToInt32(strArray[num]);
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static bool CheckEmptyFields(params string[] input)
        {
            foreach (string s in input)
                if (string.IsNullOrEmpty(s.Trim()))
                    return false;

            return true;
        }

        public static bool IsValidateEmail(string mail)
        {
            return Regex.IsMatch(mail, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        public static bool IsValidePersianDate(string date)
        {
            PersianCalendar calendar = new PersianCalendar();

            string year = date.Substring(0, 4);
            string month = date.Substring(5, 2);
            string day = date.Substring(8, 2);

            if (int.Parse(month) < 1 || int.Parse(month) > 12)
                return false;

            if (int.Parse(day) < 1)
                return false;

            if (int.Parse(month) <= 6)
                if (int.Parse(day) > 31)
                    return false;

            if (int.Parse(month) >= 7 && int.Parse(month) <= 11)
                if (int.Parse(day) > 30)
                    return false;

            if (int.Parse(month) == 12)
                if (calendar.IsLeapYear(int.Parse(year)))
                {
                    if (int.Parse(day) > 30)
                        return false;
                }
                else
                    if (int.Parse(day) > 29)
                        return false;

            return true;
        }
    }
}
