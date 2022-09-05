
string[] words = { "Sun", "Monday", "Tue",
      "W", "5", "Friday", "Saturday" };

Console.Clear();

PrintArray(words);

for (int i = 0; i < words.Length; i++)
{
    if(words[i].Length <=3)
    {
    Console.Write("[{0}] ", words[i]);
    }
}
Console.ReadKey();

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + "; ");
        else Console.Write(array[i] + "]");
    }
    Console.Write(" -> ");
}