namespace Program
{
    internal class Product
    {
        protected string Name;
        protected double Price;
        protected Currency Cost;
        protected int Quantity;
        protected string Producer;
        protected double Weight;

        public Product(string name, double price, Currency cost, int quantity, string producer, double weight)
        {
            Name = name;
            Price = price;
            Cost = new Currency(cost);
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }

        public Product(string name, double price, Currency cost)
        {
            Name = name;
            Price = price;
            Cost = new Currency(cost);
            Quantity = 1;
            Producer = "Unknown";
            Weight = 0.0;
        }
        public Product(Product obj)
        {
            Name = obj.Name;
            Price = obj.Price;
            Cost = new Currency(obj.Cost);
            Quantity = obj.Quantity;
            Producer = obj.Producer;
            Weight = obj.Weight;
        }
        public Product()
        {
            Name = "Generic Product";
            Price = 10.0;
            Cost = new Currency();
            Quantity = 1;
            Producer = "Default Producer";
            Weight = 1.0;
        }

        public double GetPriceInUAH()
        {
            return Price * Cost.GetExRate();
        }

        public double GetTotalPriceInUAH()
        {
            return GetPriceInUAH() * Quantity;
        }

        public double GetTotalWeight()
        {
            return Weight * Quantity;
        }

        public string GetName() => Name;
        public double GetPrice() => Price;
        public Currency GetCost() => new Currency(Cost);
        public int GetQuantity() => Quantity;
        public string GetProducer() => Producer;
        public double GetWeight() => Weight;

        public void SetName(string name)
        {
            Name = name;
        }
        public void SetPrice(double price)
        {
            Price = price;
        }
        public void SetCost(Currency cost)
        {
            Cost = new Currency(cost);
        }
        public void SetQuantity(int quantity)
        {
            Quantity = quantity;
        }
        public void SetProducer(string producer)
        {
            Producer = producer;
        }
        public void SetWeight(double weight)
        {
            Weight = weight;
        }
    }
}
