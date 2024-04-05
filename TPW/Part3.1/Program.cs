namespace Part3._1
{
    class Worker(string name, string surname, float rate, int days)
    {
        public string Name { get; set; } = name;
        public string Surname { get; set; } = surname;
        float Rate { get; set; } = rate;
        public int Days { get; set; } = days;

        public float GetSalary()
        {
            return Rate * Days;
        }
    }
    internal class Program
    {
        static void Main()
        {
            Worker Stonecutter = new("Каменщик", "Сахаров", 0, 3);
            Worker LazyOne = new("Григорий", "Лентяев", 0.5f, 7);
            Console.WriteLine($"Расчёт зарплаты для: {Stonecutter.Name} {Stonecutter.Surname}\n" +
                $"{Stonecutter.GetSalary()}$ за {Stonecutter.Days} дней работы");

            Console.WriteLine($"Расчёт зарплаты для: {LazyOne.Name} {LazyOne.Surname}\n" +
                $"{LazyOne.GetSalary()}$ за {LazyOne.Days} дней работы");
        }
    }
}
