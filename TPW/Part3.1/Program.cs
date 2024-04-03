namespace Part3._1
{
    class Worker
    {
        public string name { get; set; }
        public string surname { get; set; }
        float rate { get; set; }
        public int days { get; set; }

        public Worker(string name, string surname, float rate, int days)
        {
            this.name = name;
            this.surname = surname;
            this.rate = rate;
            this.days = days;
        }
        public float GetSalary()
        {
            return rate * days;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker Stonecutter = new("Каменщик", "Сахаров", 0, 3);
            Worker LazyOne = new("Григорий", "Лентяев", 0.5f, 7);
            Console.WriteLine($"Расчёт зарплаты для: {Stonecutter.name} {Stonecutter.surname}\n" +
                $"{Stonecutter.GetSalary()}$ за {Stonecutter.days} дней работы");

            Console.WriteLine($"Расчёт зарплаты для: {LazyOne.name} {LazyOne.surname}\n" +
                $"{LazyOne.GetSalary()}$ за {LazyOne.days} дней работы");
        }
    }
}
