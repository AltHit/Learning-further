namespace Part2._4
{
    class Counter
    {
        public int Count;
        public Counter(int value = 0) 
        { 
            int Count = value;
        }

        public void Up() { Count++; }
        public void Down() { Count--; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Game Of Nothing!\n\n" +
                "Rules of this game are simple: Do not press enter for the longest time possible.\n" +
                "For every 5 seconds you'll get a point and for every time you'll press enter - you loose a point.");
            Counter score = new();
            while(!Console.KeyAvailable) 
            {
                Thread.Sleep(5000);
                score.Up();
            }
            score.Down();
            Console.WriteLine($"You Failed!\n" +
                $"You got {score.Count} points");
        }
    }
}
