using System;
using System.Collections.Generic;

namespace sedgewick_algorithms.Chapter_1.Topic_1_2_DataAbstraction
{
    public class E_1_2_11_SmartDate : Date
    {
        private Dictionary<int, int> _daysInAMonth = new Dictionary<int, int>()
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

        public E_1_2_11_SmartDate(int month, int day, int year) : base(month, day, year)
        {
            ValidateMonth(month);
            ValidateDay(day);
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
            var daysInAMonth = _daysInAMonth[Month] + AddLeapDay();
            
            if (day < 1 || day > daysInAMonth)
            {
                throw new ArgumentOutOfRangeException($"Amount of days in month {Month} should be between 1 and {_daysInAMonth[Month]}");
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