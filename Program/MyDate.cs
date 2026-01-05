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

        public int GetHour() => Hours;
        public int GetMinute() => Minutes;
        public int GetDay() => Day;
        public int GetMonth() => Month;
        public int GetYear() => Year;

        public void SetHour(int hours) => Hours = hours;
        public void SetMinute(int minutes) => Minutes = minutes;
        public void SetDay(int days) => Day = days;
        public void SetMonth(int month) => Month = month;
        public void SetYear(int year) => Year = year;


    }
}
