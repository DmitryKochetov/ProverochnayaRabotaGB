
string[] words = { "Sun", "Monday", "Tue",
      "W", "5", "Friday", "Saturday" };

Console.Clear();

for (int i = 0; i < words.Length; i++)
{
    if(words[i].Length <=3)
    {
    Console.WriteLine("AS[{0}] = {1}", i, words[i]);
    }
}
Console.ReadKey();
