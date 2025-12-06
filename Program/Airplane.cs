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

        public void GetTotalTime()
        {
            int totalHours = ((FinishDate.GetHours() - StartDate.GetHours()) * 60 + FinishDate.GetMinutes() - StartDate.GetMinutes()) / 60;
            int totalMinutes = ((FinishDate.GetHours() - StartDate.GetHours()) * 60 + FinishDate.GetMinutes() - StartDate.GetMinutes()) % 60;
            Console.WriteLine($"You've been travelling for {totalHours} hours and {totalMinutes} minutes");
        }
    }
}
