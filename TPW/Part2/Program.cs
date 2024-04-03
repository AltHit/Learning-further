namespace Part2
{
    class Student
    {
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public int Group { get; set; }
        public int[] Grades { get; set; }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            Student student = new() { Surname = "Ivanov", Birthday = new DateTime(2005, 3, 15), Group = 812, Grades = [5,4,3,3,5] };
            Console.WriteLine("Enter information about student (Surname, Date of birth, Group number and grades");

            Student student1 = new() 
            { 
                Surname = Console.ReadLine(),
                Birthday = DateTime.Parse(Console.ReadLine()),
                Group = int.Parse(Console.ReadLine()),
                Grades = Console.ReadLine().Split(' ').Select(int.Parse).ToArray() 
            };

            Console.WriteLine("Accessing information about student...");
            Console.WriteLine($"Student's surname is: {student1.Surname}");
            Console.WriteLine($"Born in: Year {student1.Birthday.Year}, in {student1.Birthday:MMMM} {student1.Birthday.Day}'th");
            Console.WriteLine($"Currently in group {student1.Group}");
            Console.WriteLine("Last grades are:");
            foreach(int i in student1.Grades) {  Console.WriteLine(i); }
        }
    }
}
