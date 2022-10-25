using ConsoleApp241022;

int n = int.Parse(Console.ReadLine());

List<int> numbers = new List<int>(n);

string[] strs = Console.ReadLine().Split(new char[] { ' ' });

for (int i = 0; i < strs.Length; i++)
{
    numbers.Add(int.Parse(strs[i]));
}

Logic logic = new Logic();

logic.NumbersDifferenceCorrectWithChanges(ref numbers);

//numbers.ForEach((s) => Console.WriteLine(s));
Console.WriteLine("\nИтог " + numbers.Count);

Console.ReadKey();