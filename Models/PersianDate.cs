using System.Globalization;
using System;
namespace Flight
{
   public static class Extensions
    {
        public static String ToShamsi(this DateTime Miladi)
        {

            PersianCalendar persian = new PersianCalendar();
            string shamsi = persian.GetYear(Miladi).ToString("0000") + "/" + persian.GetMonth(Miladi).ToString("00") + "/" + persian.GetDayOfMonth(Miladi).ToString("00");
            return shamsi;


        }


        public static DateTime ToGeorgianDateTime(this string persianDate)
        {
            int year = Convert.ToInt32(persianDate.Substring(0, 4));
            int month = Convert.ToInt32(persianDate.Substring(5, 2));
            int day = Convert.ToInt32(persianDate.Substring(8, 2));
            DateTime georgianDateTime = new DateTime(year, month, day, new System.Globalization.PersianCalendar());
            return georgianDateTime;
        }
    }

 
}
