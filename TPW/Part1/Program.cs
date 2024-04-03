using System.Text;

//#1
//Input is two strings: J and S. Output is int of how many Js are in S

//Console.WriteLine("Input your Jades and Stones");
//List<char> jades = [.. Console.ReadLine()];
//List<char> stones = [.. Console.ReadLine()];
//int counterFirst = 0;
//jades = jades.Distinct().ToList();

//foreach (char j in jades) //uncomment write-lines to debug
//{
//    //Console.WriteLine($"Current jade is: {j}");
//    foreach (char s in stones)
//    {
//        //Console.WriteLine($"Current stone is: {s}");
//        if (s == j) 
//        {
//            counterFirst++;
//            //Console.WriteLine("GOLD!");
//        }
//    }
//}

//Console.WriteLine($"We found {counterFirst} jades in stones!");

//#2
//input is an array of 'candidate' numbers and sum. Output is set of unique combinations of candidate numbers that adds up to the sum

//Console.WriteLine("Input!");

//List<int> candidates = [.. Console.ReadLine()];
//int sum = int.Parse(Console.ReadLine());

//for (int i = 0; i < candidates.Count(); i++)
//{
//    if (candidates[i] > sum) { candidates.RemoveAt(i); i--; continue; }
//    if (candidates[i] == sum) { Console.WriteLine(candidates[i]); candidates.RemoveAt(i); i--; }
//}

//foreach (int i in candidates)
//{
//    Console.WriteLine(candidates[i]);
//}

//#3
//Input is an int array. Output true if all elements of an array is unique or output false if at least one element is duplicated
//Console.WriteLine("Input array and we'll check it for duplicates");
//List<int> numsThird = [.. Console.ReadLine()]; //read numbers to list
//List<int> numsDist = numsThird.Distinct().ToList(); //create list with only unique numbers
//if (numsThird.SequenceEqual(numsDist))  {   Console.WriteLine("false");  } //compare input list to unique list
//else{Console.WriteLine("true");} //profit!!!!