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

        public Airplane(string finishCity, MyDate startDate, MyDate finishDate)
        {
            StartCity = "Zhytomyr";
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

        public int GetTotalTime()
        {
            int totalHours = ((FinishDate.GetHour() - StartDate.GetHour()) * 60 +
                FinishDate.GetMinute() - StartDate.GetMinute()) / 60 + (FinishDate.GetDay() - StartDate.GetDay()) * 24;
            int totalMinutes = ((FinishDate.GetHour() - StartDate.GetHour()) * 60 + FinishDate.GetMinute() - StartDate.GetMinute()) % 60;
            return totalMinutes + totalHours * 60;
        }

        public bool IsArrivingToday()
        {
            return StartDate.GetDay() == FinishDate.GetDay() &&
                   StartDate.GetMonth() == FinishDate.GetMonth() &&
                   StartDate.GetYear() == FinishDate.GetYear();
        }

        public string GetStartCity() => StartCity;
        public string GetFinishCity() => FinishCity;
        public MyDate GetStartDate() => new MyDate(StartDate);
        public MyDate GetFinishDate() => new MyDate(FinishDate);

        public void SetStartCity(string startCity) => StartCity = startCity;
        public void SetFinishCity(string finishCity) => FinishCity = finishCity;
        public void SetStartDate(MyDate startDate) => StartDate = new MyDate(startDate);
        public void SetFinishDate(MyDate finishDate) => FinishDate = new MyDate(finishDate);
    }
}
