
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