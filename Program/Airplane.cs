namespace Program
{
    internal class Airplane
    {
        protected string StartCity;
        protected string FinishCity;
        protected MyDate StartDate;
        protected MyDate FinishDate;

        public Airplane(string startCity, string finishCity, MyDate startDate, MyDate finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = new MyDate(startDate);
            FinishDate = new MyDate(finishDate);
        }

        public Airplane(string startCity, string finishCity, MyDate startDate, MyDate finishDate, string airplaneName)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = new MyDate(startDate);
            FinishDate = new MyDate(finishDate);
        }

        public Airplane(Airplane obj)
        {
            StartCity = obj.StartCity;
            FinishCity = obj.FinishCity;
            StartDate = new MyDate(obj.StartDate);
            FinishDate = new MyDate(obj.FinishDate);
        }

        public Airplane()
        {
            StartCity = "Kyiv";
            FinishCity = "Budapest";
            StartDate = new MyDate();
            FinishDate = new MyDate(1, 6, 15);
        }

        public void GetTotalTime()
        {
            int totalHours = ((FinishDate.GetHours() - StartDate.GetHours()) * 60 +
                FinishDate.GetMinutes() - StartDate.GetMinutes()) / 60 + (FinishDate.GetDays() - StartDate.GetDays()) * 24;
            int totalMinutes = ((FinishDate.GetHours() - StartDate.GetHours()) * 60 + FinishDate.GetMinutes() - StartDate.GetMinutes()) % 60;
            Console.WriteLine($"You've been travelling for {totalHours} hours and {totalMinutes} minutes");
        }

        public bool IsArrivingToday()
        {
            return StartDate.GetDays() == FinishDate.GetDays() &&
                   StartDate.GetMonths() == FinishDate.GetMonths();
        }
    }
}
