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
    }
}
