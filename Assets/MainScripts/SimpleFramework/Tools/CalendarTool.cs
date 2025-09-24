using System;
using System.Globalization;

public static class CalendarTool
{
    public static string GetWeekDayName(int nYear, int nMonth, int nDay)
    {
        DateTime dateTime = new DateTime(DateTime.Now.Year, nMonth, 1);
        string name = LanguageManager.Instance.GetCultureName();
        return dateTime.ToString("ddd", CultureInfo.GetCultureInfo(name));
    }

    public static string GetMonthName(int nMonth)
    {
        DateTime dateTime = new DateTime(DateTime.Now.Year, nMonth, 1);

        string name = LanguageManager.Instance.GetCultureName();
        return dateTime.ToString("MMM", CultureInfo.GetCultureInfo(name));
    }

    public static int GetWeekDay(int nYear, int nMonth, int nDay)
	{
		DateTime dateTime = new DateTime(nYear, nMonth, nDay);
		return (int)dateTime.DayOfWeek;
	}

    public static int DaysInMonth(int nYear, int nMonth)
    {
        return DateTime.DaysInMonth(nYear, nMonth);
    }

    public static DateTime[] GetMonthBeginEndDay(int nYear, int nMonth)
    {
        int nLastMonth_Year = nYear;
        int nLastMonth_Month = nMonth - 1;
        if (nMonth - 1 <= 0)
        {
            nLastMonth_Year = nYear - 1;
            nLastMonth_Month = 12;
        }
            
        int nNextMonth_Year = nYear;
        int nNextMonth_Month = nMonth + 1;
        if (nMonth + 1 > 12)
        {
            nNextMonth_Year = nYear + 1;
            nNextMonth_Month = 1;
        }
            
        int nLastMonthSumDays = DateTime.DaysInMonth(nLastMonth_Year, nLastMonth_Month);
        int nThisMonthSumDays = DateTime.DaysInMonth(nYear, nMonth);
        int nDay1WeekOfDay = CalendarTool.GetWeekDay(nYear, nMonth, 1);
        DateTime[] dayArray = new DateTime[42];
        
        int Offset = nDay1WeekOfDay;
        for (int i = 0; i < 42; i++)
        {
            DateTime mDateTime;
            if (i < Offset)
            {
                int nDay = nLastMonthSumDays - Offset + i + 1;
                mDateTime = new DateTime(nLastMonth_Year, nLastMonth_Month, nDay);
            }
            else
            {
                int nDay = i - Offset + 1;
                if (nDay <= nThisMonthSumDays)
                {
                    mDateTime = new DateTime(nYear, nMonth, nDay);
                }
                else
                {
                    nDay = nDay - nThisMonthSumDays;
                    mDateTime = new DateTime(nNextMonth_Year, nNextMonth_Month, nDay);
                }
            }
            dayArray[i] = mDateTime;
        }
        
        return dayArray;
    }
    
}

