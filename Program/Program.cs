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
                new MyDate(1, 1, 2024, 13, 18)
            );
            airplane.GetTotalTime();
        }
    }
}