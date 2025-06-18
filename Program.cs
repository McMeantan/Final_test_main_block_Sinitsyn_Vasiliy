Console.WriteLine("Введите строки через пробел:");

string input = Console.ReadLine();

string[] inputArray = input.Split(' ');

List<string> resultList = new List<string>();

foreach (string str in inputArray)
{
    if (str.Length <= 3)
    {
        resultList.Add(str);
    }
}

string[] resultArray = resultList.ToArray();

Console.WriteLine("Строки длиной <= 3:");

        foreach (string str in resultArray)
        {
            Console.WriteLine(str);
        }
