using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymClass
{
    class ValidDate
    {
        private enum MONTHS
        {
            Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec
        };

        private int[] DAYS_IN_MONTHS = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private int _year;
        private int _month;
        private int _day;
        public ValidDate ( int day, int month, int year)
        {
            this._day = day;
            this._month = month;
            this._year = year;
        }      
        public int GetYear()
        {
            return this._year;
        }
        public int GetMonth()
        {
            return this._month;
        }
        public ValidDate NextMonth()
        {
            if (this._month == (int)MONTHS.Jan + 1 && this._day >= 29 && IsLeapYear(this._year))
            {
                this._day = 29;
                this._month = (int)MONTHS.Feb + 1;
                return this;
            }
            if (this._month - 1 == (int)MONTHS.Dec)
            {
                this._month = 1;
                this._year++;
            }
            if (this._day == DAYS_IN_MONTHS[this._month - 1])
            {
                if (this._month == (int)MONTHS.Dec + 1)
                    this._day = DAYS_IN_MONTHS[(int)MONTHS.Jan];
                else
                    this._day = DAYS_IN_MONTHS[this._month];
                this._month++;
            }
            else if (this._day > DAYS_IN_MONTHS[this._month])
            {
                this._day = DAYS_IN_MONTHS[this._month];
                this._month++;
            }
            else
                this._month++;
            return this;
        }
        public string toString()
        {
            string dayName = "";
            string dayString = this._day.ToString();
            string monthName = "";
            string year = this._year.ToString();
            int day = GetDayOfWeek( this._day, this._month, this._year );
            switch ( day )
            {
                case (int)DayOfWeek.Sunday:
                    dayName = "Sunday ";
                    break;
                case (int)DayOfWeek.Monday:
                    dayName = "Monday ";
                    break;
                case (int)DayOfWeek.Tuesday:
                    dayName = "Tuesday ";
                    break;
                case (int)DayOfWeek.Wednesday:
                    dayName = "Wednesday ";
                    break;
                case (int)DayOfWeek.Thursday:
                    dayName = "Thursday ";
                    break;
                case (int)DayOfWeek.Friday:
                    dayName = "Friday ";
                    break;
                case (int)DayOfWeek.Saturday:
                    dayName = "Saturday ";
                    break;
                default:
                    break;
            }
            switch ( this._month - 1 )
            {
                case (int)MONTHS.Jan:
                    monthName = " Jan ";
                        break;
                case (int)MONTHS.Feb:
                    monthName = " Feb ";
                        break;
                case (int)MONTHS.Mar:
                    monthName = " Mar ";
                        break;
                case (int)MONTHS.Apr:
                    monthName = " Apr ";
                        break;
                case (int)MONTHS.May:
                    monthName = " May ";
                        break;
                case (int)MONTHS.Jun:
                    monthName = " Jun ";
                        break;
                case (int)MONTHS.Jul:
                    monthName = " Jul ";
                        break;
                case (int)MONTHS.Aug:
                    monthName = " Aug ";
                        break;
                case (int)MONTHS.Sep:
                    monthName = " Sep ";
                        break;
                case (int)MONTHS.Oct:
                    monthName = " Oct ";
                        break;
                case (int)MONTHS.Nov:
                    monthName = " Nov ";
                        break;
                case (int)MONTHS.Dec:
                    monthName = " Dec ";
                        break;
                default:
                    break;
            }
            return dayName + dayString + monthName + year;
        }
        public bool IsLeapYear( int year )
        {
            if ( year % 4 == 0 )
            {
                if (year % 400 == 0)
                    return true;
                else if (year % 100 == 0)
                    return false;
                else
                    return true;
            }
            else
                return false;
        }
        public int GetDayOfWeek( int day, int month, int year )
        {
            int []t = { 0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 };
            if (month < 3)
                year -= 1;
            return ( year + year / 4 - year / 100 + year / 400 + t[month - 1] + day ) % 7;
        }
    }
}
