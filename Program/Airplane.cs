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
            int startTotalMinutes = StartDate.GetHours() * 60 + StartDate.GetMinutes();
            int finishTotalMinutes = FinishDate.GetHours() * 60 + FinishDate.GetMinutes();
            if (FinishDate.GetDay() != StartDate.GetDay())
            {
                finishTotalMinutes += 24 * 60;
            }
            if (FinishDate.GetMonth() != StartDate.GetMonth())
            {
                finishTotalMinutes += 30 * 24 * 60;
            }
            if (FinishDate.GetYear() != StartDate.GetYear())
            {
                finishTotalMinutes += 365 * 24 * 60;
            }
            return finishTotalMinutes - startTotalMinutes;
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
