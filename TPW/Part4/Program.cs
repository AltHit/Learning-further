int RimToInt(char rim)
{
    switch (rim)
    {
        case 'I':
            return 1;
        case 'V':
            return 5;
        case 'X':
            return 10;
        case 'L':
            return 50;
        case 'C':
            return 100;
        case 'D':
            return 500;
        case 'M':
            return 1000;
        default:
            throw new ArgumentException("ERR: Not a Roman numeral!");
    }
}
bool CheckDiff(char _right, char _left)
{
    int right = RimToInt(_right);
    int left = RimToInt(_left);
    switch (left)
    {
        case 1:
            if (right == 5 || right == 10) { return true; }
            else { return false; }
        case 10:
            if (right == 50 || right == 100) { return true; }
            else { return false; }
        case 100:
            if (right == 500 || right == 1000) { return true; }
            else { return false; }
        default:
            return false;
    }
}
Console.WriteLine("Введите Римское число и мы попробуем перевести его");
string input = Console.ReadLine();
int output = 0;
for (int i = input.Length - 1; i >= 0; i--)
{
    if (i >= 2 &&(input[i] == input[i - 1]) && (input[i - 1] == input[i - 2]))
    {
        output += RimToInt(input[i]) * 3;
        i -= 2;
        continue;
    }
    else if (i >= 1 && (input[i] == input[i - 1]))
    {
        output += RimToInt(input[i]) * 2;
        i -= 1;
        continue;
    }
    else if (i >= 1 && CheckDiff(input[i], input[i - 1]))
    {
        output += RimToInt(input[i]) - RimToInt(input[i - 1]);
        i -= 1;
        continue;
    }
    else
    {
        output += RimToInt(input[i]);
    }
}
Console.WriteLine(output);