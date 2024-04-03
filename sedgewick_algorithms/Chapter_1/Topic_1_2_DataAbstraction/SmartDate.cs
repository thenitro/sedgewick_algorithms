using System;
using System.Collections.Generic;

namespace sedgewick_algorithms.Chapter_1.Topic_1_2_DataAbstraction
{
    public class SmartDate : Date
    {
        private static readonly int[] DayOfTheWeekMagicNumber = { 0, 3, 3, 6, 1, 4, 6, 2, 5, 0, 3, 5 };

        private static readonly Dictionary<int, string> DayNumberToName = new Dictionary<int, string>()
        {
            { 0, "Sunday"},
            { 1, "Monday"},
            { 2, "Tuesday"},
            { 3, "Wednesday"},
            { 4, "Thursday"},
            { 5, "Friday"},
            { 6, "Saturday"},
        };

        private const int CurrentCenturyValue = 6;

        private static readonly Dictionary<int, int> DaysInAMonth = new Dictionary<int, int>()
        {
            { 1, 31 },
            { 2, 28 },
            { 3, 31 },
            { 4, 30 },
            { 5, 31 },
            { 6, 30 },
            { 7, 31 },
            { 8, 31 },
            { 9, 30 },
            { 10, 31 },
            { 11, 30 },
            { 12, 31 },
        };

        public SmartDate(int month, int day, int year) : base(month, day, year)
        {
            ValidateMonth(month);
            ValidateDay(day);
        }

        public string DayOfTheWeek()
        {
            var calculation = (Year + Year / 4 - Year / 100 + Year / 400 + DayOfTheWeekMagicNumber[Month - 1] + Day + CurrentCenturyValue) % 7;
            return DayNumberToName[calculation];
        }

        private void ValidateMonth(int month)
        {
            if (month < 1 || month > 12)
            {
                throw new ArgumentOutOfRangeException($"Month {month} should be between 1 and 12");
            }
        }
        
        private void ValidateDay(int day)
        {
            var daysInAMonth = DaysInAMonth[Month] + AddLeapDay();
            
            if (day < 1 || day > daysInAMonth)
            {
                throw new ArgumentOutOfRangeException($"Amount of days in month {Month} should be between 1 and {DaysInAMonth[Month]}");
            }
        }

        private int AddLeapDay()
        {
            if (Month != 2) return 0; 
            return IsLeapYear(Year) ? 1 : 0;
        }

        private bool IsLeapYear(int year)
        {
            return (year % 400 == 0) || (year % 100 != 0 && year % 4 == 0);
        }
    }
}