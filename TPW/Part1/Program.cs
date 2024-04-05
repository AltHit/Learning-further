using System.Text;

static IList<IList<int>> CheckForTarget(int[] candidates, int target)
{
    Array.Sort(candidates);

    IList<IList<int>> result = [];

    FindCombinations(candidates, target, 0, [], result);
    return result;
}

static void FindCombinations(int[] candidates, int target, int begin, List<int> current, IList<IList<int>> result)
{

    if (target == 0)
    {
        result.Add(new List<int>(current));
        return;
    }

    for (int i = begin; i < candidates.Length; i++)
    {
        if (i > begin && candidates[i] == candidates[i - 1])
        {
            continue;
        }

        if (candidates[i] > target)
        {
            break;
        }

        current.Add(candidates[i]);
        FindCombinations(candidates, target - candidates[i], i + 1, current, result);
        current.RemoveAt(current.Count - 1);
    }
}

//#1
//Input is two strings: J and S. Output is int of how many Js are in S

Console.WriteLine("Input your Jades and Stones");
List<char> jades = [.. Console.ReadLine()];
List<char> stones = [.. Console.ReadLine()];
int counterFirst = 0;
jades = jades.Distinct().ToList();

foreach (char j in jades) //uncomment write-lines to debug
{
    //Console.WriteLine($"Current jade is: {j}");
    foreach (char s in stones)
    {
        //Console.WriteLine($"Current stone is: {s}");
        if (s == j)
        {
            counterFirst++;
            //Console.WriteLine("GOLD!");
        }
    }
}

Console.WriteLine($"We found {counterFirst} jades in stones!");

//#2
//input is an array of 'candidate' numbers and sum. Output is set of unique combinations of candidate numbers that adds up to the sum

Console.WriteLine("Enter a line of digits and then a target for them");
int[] candidates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int target = int.Parse(Console.ReadLine());

foreach (var output in CheckForTarget(candidates, target)) 
{
    Console.WriteLine($"[{string.Join(",", output)}],");
}


//#3
//Input is an int array. Output true if all elements of an array is unique or output false if at least one element is duplicated
Console.WriteLine("Input array and we'll check it for duplicates");
List<int> numsThird = [.. Console.ReadLine()]; //read numbers to list
List<int> numsDist = numsThird.Distinct().ToList(); //create list with only unique numbers
if (numsThird.SequenceEqual(numsDist)) { Console.WriteLine("false"); } //compare input list to unique list
else { Console.WriteLine("true"); } //profit!!!!