namespace Part3._2
{
    class PrivateWorker
    {
        private string name { get; set; }
        private string surname { get; set; }
        private float rate { get; set; }
        private int days { get; set; }

        public PrivateWorker(string name, string surname, float rate, int days)
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

        public string GetName() { return name; }
        public string GetSurname() {  return surname; }
        public float GetRate() { return rate; }
        public int GetDays() { return days; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PrivateWorker pusher = new PrivateWorker("Anton", "Owerworkov", 10.2f, 14);
            Console.WriteLine($"Работник {pusher.GetName()} отлично постарался в этом квартале!\n" +
                $"За {pusher.GetDays()} дней работы он перевыполнил норму\n" +
                $"С учётом премии ему нужно выплатить {pusher.GetSalary()}$");
        }
    }
}
