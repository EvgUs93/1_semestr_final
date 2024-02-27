int array_len = 0;
int new_len = 0;
main();
void main()
{
    string[] array = GetArray();
    string[] new_array = NewArray(array);
    PrintArray(array);
    Console.Write("==>");
    PrintArray(new_array);
}







string[] GetArray()
{
    Console.Write("Введите желаемую длинну массива:");
    array_len = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[array_len];
    for (int i = 0; i < array_len; i++)
    {
        Console.WriteLine("Введите значение");
        array[i] = Console.ReadLine();
        if (array[i].Length <= 3)
        {
            new_len += 1;
        }
    }
    return array;
}
string[] NewArray(string[] array)
{
    string[] new_array = new string[new_len];
    int index = 0;
    for (int i = 0; i < array_len; i++)
    {
        if (array[i].Length <= 3)
        {
            new_array[index] = array[i];
            index++;
        }
    }
    return new_array;
}
void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"“{array[i]}”, ");
    }
    Console.Write("] ");
}