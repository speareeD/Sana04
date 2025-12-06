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

        public MyDate(MyDate date)
        {
            Day = date.Day;
            Month = date.Month;
            Year = date.Year;
            Hours = date.Hours;
            Minutes = date.Minutes;
        }
    }
}
