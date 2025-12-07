namespace Program
{
    internal class MyDate
    {
        protected int Day;
        protected int Month;
        protected int Year;
        protected int Hours;
        protected int Minutes;

        public MyDate(int day, int month, int year, int hours, int minutes)
        {
            Day = day;
            Month = month;
            Year = year;
            Hours = hours;
            Minutes = minutes;
        }

        public MyDate(int day, int hours, int minutes)
        {
            Day = day;
            Hours = hours;
            Minutes = minutes;
        }

        public MyDate()
        {
            Day = 1;
            Month = 1;
            Year = 2025;
            Hours = 5;
            Minutes = 5;
        }

        public MyDate(MyDate date)
        {
            Day = date.Day;
            Month = date.Month;
            Year = date.Year;
            Hours = date.Hours;
            Minutes = date.Minutes;
        }

        public int GetHours()
        {
            return Hours;
        }

        public int GetMinutes()
        {
            return Minutes;
        }

        public int GetDays()
        {
            return Day;
        }

        public int GetMonths()
        {
            return Month;
        }
    }
}
