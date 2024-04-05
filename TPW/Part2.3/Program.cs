namespace Part2._3
{
    class Numbers
    {
        public int A { get; set; }
        public int B { get; set; }

        public void Read()
        {
            Console.WriteLine(A);
            Console.WriteLine(B);
        }

        public void WriteA(int _a) { A = _a; }
        public void WriteB(int _b) { B = _b; }
        public int Sum() { return A + B; }
        public int Greater() { return A>B? A : B; }
    }
    internal class Program
    {
        static void Main()
        {
            Numbers numbers = new();
            Console.WriteLine("Set values of A and B");
            numbers.WriteA(int.Parse(Console.ReadLine()));
            numbers.WriteB(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Sum of A and B is {numbers.Sum()}");
            Console.WriteLine($"Greater number is {numbers.Greater()}");
            Console.WriteLine($"The numbers were...");
            numbers.Read();
        }
    }
}
