namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Airplane airplane = new Airplane(
                "New York",
                "Los Angeles",
                new MyDate(1, 1, 2024, 10, 30),
                new MyDate(2, 1, 2024, 13, 15)
            );
            Console.WriteLine("Total travel time: " + airplane.GetTotalTime() + " minutes");
            Console.WriteLine($"You will arrive today: {airplane.IsArrivingToday()}\n");

            Product product = new Product(
                "Laptop",
                999.99,
                new Currency("USD", 42.16),
                25,
                "Acer",
                2.5

            );
            double priceInUAH = product.GetPriceInUAH();
            Console.WriteLine($"Price of {product.GetName()} {product.GetProducer()} is {priceInUAH} UAH");
            double totalPriceUAH = product.GetTotalPriceInUAH();
            Console.WriteLine($"Total price of {product.GetName()} {product.GetProducer()} available in warehouse is {totalPriceUAH}");
            double totalWeight = product.GetTotalWeight();
            Console.WriteLine($"Total weight of all {product.GetName()} {product.GetProducer()} is {totalWeight}");
        }
    }
}