namespace Part3._3
{
    class Calculation
    {
        private string calculationLine;
        public void SetCalculationLine(string calculationLine)
        {
            this.calculationLine = calculationLine;
        }
        public void SetLastSymbol(char lastSymbolCalculationLine)
        {
            calculationLine += lastSymbolCalculationLine;
        }
        public string GetCalculationLine()
        {
            return calculationLine;
        }
        public char GetLastSymbol()
        {
            return calculationLine[calculationLine.Length - 1];
        }
        public void DeleteLastSymbol()
        {
            calculationLine = calculationLine.Remove(calculationLine.Length-1);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation line = new();
            Console.WriteLine("Перед вами умная строка\n" +
                "Введите 's' чтобы установить значение строки\n" +
                "l - чтобы установить последний символ строки\n" +
                "d - чтобы удалить последний символ\n" +
                "g - чтобы получить всю строку\n" +
                "h - чтобы получить последний символ\n" +
                "q - чтобы выйти");
            char input = char.Parse(Console.ReadLine());
            while (input != 'q') 
            {
                switch (input)
                {
                    case 's':
                        Console.WriteLine("Введите новое значение строки");
                        line.SetCalculationLine(Console.ReadLine());
                        break;
                    case 'l':
                        Console.WriteLine("Введите символ");
                        line.SetLastSymbol(char.Parse(Console.ReadLine()));
                        break;
                    case 'd':
                        Console.WriteLine("Удаление...");
                        line.DeleteLastSymbol();
                        break;
                    case 'g':
                        Console.WriteLine(line.GetCalculationLine());
                        break;
                    case 'h':
                        Console.WriteLine(line.GetLastSymbol());
                        break;
                }
                input = char.Parse(Console.ReadLine());
            }
        }
    }
}
