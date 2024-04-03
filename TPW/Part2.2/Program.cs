namespace Part2._2 //I love trains!
{
    class Train
    {
        public string Destination { get; set; }
        public int TrainID { get; set; }
        public TimeOnly Departure { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press Enter to start inputing train data or enter \"Skip\" to use premade ones");
            List<Train> depot = new();
            if (Console.ReadLine() == "Skip")
            {
                depot =
                [
                    new Train(){Destination = "Home", TrainID = 0, Departure = TimeOnly.Parse("12:00") },
                    new Train(){Destination = "Hell", TrainID = -1, Departure = TimeOnly.Parse("06:06") },
                    new Train(){Destination = "Pain", TrainID = 10, Departure = TimeOnly.Parse("13:48") },
                    new Train(){Destination = "Terra", TrainID = 40000, Departure = TimeOnly.Parse("03:12") },
                    new Train(){Destination = "Corporation W", TrainID = 5, Departure = TimeOnly.Parse("05:05") },
                ];
            }
            else
            {
                Console.WriteLine("You'll need to type inside various data about train in format of Destination point, Number of train and Departure time\n" +
                                  "You need to do that 5 times to fill the list. Good Luck!");
                depot =
                [
                    new Train(){Destination = Console.ReadLine(), TrainID = int.Parse(Console.ReadLine()), Departure = TimeOnly.Parse(Console.ReadLine()) },
                    new Train(){Destination = Console.ReadLine(), TrainID = int.Parse(Console.ReadLine()), Departure = TimeOnly.Parse(Console.ReadLine()) },
                    new Train(){Destination = Console.ReadLine(), TrainID = int.Parse(Console.ReadLine()), Departure = TimeOnly.Parse(Console.ReadLine()) },
                    new Train(){Destination = Console.ReadLine(), TrainID = int.Parse(Console.ReadLine()), Departure = TimeOnly.Parse(Console.ReadLine()) },
                    new Train(){Destination = Console.ReadLine(), TrainID = int.Parse(Console.ReadLine()), Departure = TimeOnly.Parse(Console.ReadLine()) }
                ];
                Console.WriteLine("Now write needed ID and we'll try to find your train");
                Console.WriteLine(depot.Find(p => p.TrainID == int.Parse(Console.ReadLine())));
            }
            Console.WriteLine("Now write needed ID and we'll try to find your train. Type in empty line when you finish");
            int? search = int.TryParse(Console.ReadLine(), out var i) ? (int?)i : null; //tricky way to parse nullable int
            while (search != null)
            {
                Train? container = depot.Find(p => p.TrainID == search);
                if (container == null) { Console.WriteLine("Train not found!"); }
                else
                {
                    Console.WriteLine($"Выбран поезд в {container.Destination}\n" +
                        $"Время отправки: {container.Departure}");
                }
                search = int.TryParse(Console.ReadLine(), out i) ? (int?)i : null;
            }
        }
    }
}
