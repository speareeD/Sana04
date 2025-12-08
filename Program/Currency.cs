namespace Program
{
    internal class Currency
    {
        protected string Name;
        protected double ExRate;

        public Currency(string name, double exRate)
        {
            Name = name;
            ExRate = exRate;
        }

        public Currency(string name)
        {
            Name = name;
            ExRate = 1.0;
        }

        public Currency(Currency obj)
        {
            Name = obj.Name;
            ExRate = obj.ExRate;
        }

        public Currency()
        {
            Name = "USD";
            ExRate = 1.5;
        }

        public string GetName() => Name;
        public double GetExRate() => ExRate;

        public void SetName(string name)
        {
            Name = name;
        }
        public void SetExRate(double exRate)
        {
            ExRate = exRate;
        }
    }
}
