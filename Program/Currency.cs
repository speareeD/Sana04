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
