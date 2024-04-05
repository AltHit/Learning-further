namespace Part3._2
{
    class PrivateWorker(string name, string surname, float rate, int days)
    {
        private string Name { get; set; } = name;
        private string Surname { get; set; } = surname;
        private float Rate { get; set; } = rate;
        private int Days { get; set; } = days;

        public float GetSalary()
        {
            return Rate * Days;
        }

        public string GetName() { return Name; }
        public string GetSurname() {  return Surname; }
        public float GetRate() { return Rate; }
        public int GetDays() { return Days; }
    }
    internal class Program
    {
        static void Main()
        {
            PrivateWorker pusher = new("Anton", "Owerworkov", 10.2f, 14);
            Console.WriteLine($"Работник {pusher.GetName()} отлично постарался в этом квартале!\n" +
                $"За {pusher.GetDays()} дней работы он перевыполнил норму\n" +
                $"С учётом премии ему нужно выплатить {pusher.GetSalary()}$");
        }
    }
}
