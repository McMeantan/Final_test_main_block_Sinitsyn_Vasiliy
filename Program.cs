void EnterArray()
{
    Console.Write("Введите количество строк, которые хотите ввести: ");
    int n = Convert.ToInt32(Console.ReadLine()); // Считываем строку, переводим в число
    string[] strs = new string[n]; // Объявляем массив строк длиной n (которую ввёл пользователь)
    for (int i = 0; i < n; i++)
        {
            Console.Write("Введите строку №{0}:\r\n ", i + 1);
            strs[i] = Console.ReadLine(); // Заполняем его
        }
    Console.WriteLine("Вы ввели следующие строки:");
    for (int i = 0; i < n; i++)
        {
            Console.WriteLine(strs[i]);
        }
    Console.Write("Нажмите [Enter] для выхода...");
    Console.ReadLine();
}

string[] Select3OrLess(string[] s, int size)
{
   string[] array = new string[size];

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < s.Length; j++)
        {
            if (array[i].Length <= 3)
            {
                s[j] = array[i];
            }
        } 
    }

    return s;
}

void PrintArray(string[] s)
{
    Console.Write("[");

    for (int i = 0; i < s.Length; i++)
    {
        if (i < s.Length - 1)
        {
            Console.Write($"{s[i]}, ");
        }
        else
        {
            Console.Write($"{s[i]}");
        }
    }

    Console.Write("]");
}

EnterArray(arr);

string[] resArray = Select3OrLess(arr, 10);
PrintArray(resArray);