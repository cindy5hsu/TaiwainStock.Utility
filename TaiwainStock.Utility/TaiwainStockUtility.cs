using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiwainStock.Utility
{
    public class TaiwainStockUtility
    {
        public bool IsTradingTime(DateTime dt)
        {
            //判斷今天是星期幾

            int today = (int) dt.DayOfWeek;

            //判斷是否在工作時間
            //string _stockWorkingDayAM = "09:00:00";//工作时间上午09:00
            //string _stockWorkingDayPM = "17:30:00";

            //TimeSpan dspWorkingDayAM = DateTime.Parse(_stockWorkingDayAM).TimeOfDay;
            //TimeSpan dspWorkingDayPM = DateTime.Parse(_stockWorkingDayPM).TimeOfDay;

            ////string time1 = "2017-2-17 8:10:00";
            //DateTime t1 = Convert.ToDateTime(dt);

            //TimeSpan dspNow = t1.TimeOfDay;
            DateTime start = new DateTime(dt.Year, dt.Month, dt.Day, 9, 0, 0, 0);
            DateTime end = new DateTime(dt.Year, dt.Month, dt.Day,13, 30, 0, 0);
            
            if ( today <= 5 && today>=1 && dt.CompareTo(start)>=0 && dt.CompareTo(end) <= 0)
            {
                return true;
            }
            return false;
           
        }
    }
}
