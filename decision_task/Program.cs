string[] arrayfirst = new string[5] { "Hello", "345", "world", "and", "Rassia" };
string[] arraysecond = new string[arrayfirst.Length];
void GetArray(string[] arrayfirst, string[] arraysecond)
{
    int count = 0;
    for (int i = 0; i < arrayfirst.Length; i++)
    {
        if (arrayfirst[i].Length <= 3)
        {
            arraysecond[count] = arrayfirst[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
GetArray(arrayfirst, arraysecond);
PrintArray(arraysecond);

