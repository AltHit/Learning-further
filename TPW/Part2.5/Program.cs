namespace Part2._5
{
    public class Anything
    {
        public string defaulted;
        public string identified;

        public Anything()
        {
            defaulted = "We must ";
            identified = "be default";
        }

        public Anything(string def, string ident)
        {
            defaulted = def;
            identified = ident;
        }

        ~Anything()
        {
            Console.WriteLine("Anything has suddenly became nothing!");
        }
    }
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Let's begin object creation!\n" +
                "Enter nothing if you want your values to be default or enter anything if you want to create your own values");
            if (Console.ReadLine() == "")
            {
                Anything newThing = new();
                Console.WriteLine($"Nice work. Your default values are {newThing.defaulted} and {newThing.identified}\n" +
                    $"Now we'll destroy them, they aren't yours anyway");
            }
            else
            {
                Console.WriteLine("Alright then! If you want to type so much - type me 2 values for your object");
                Anything newThing = new(Console.ReadLine(), Console.ReadLine());
                Console.WriteLine($"Your values are {newThing.defaulted} and {newThing.identified}?\n" +
                    $"Good.\n" +
                    $"Now we have to destroy them!\n" +
                    $"Say your regards if you have any.");
            }
        }
    }
}
