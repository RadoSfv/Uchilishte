using System;

namespace List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersMore = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] tokens = command.Split();
                if (tokens[0] == "Contains")
                {
                    int num = int.Parse(tokens[1]);
                    if (numbersMore.Contains(num))
                    {
                        Console.WriteLine("Yes");
                    }
                    else Console.WriteLine("No such number");
                }
                else if (tokens[0] == "PrintEven")
                {
                    List<int> printEven = numbersMore.Where(x => x % 2 == 0).ToList();
                    Console.WriteLine(string.Join(" ", printEven));
                }
                else if (tokens[0] == "PrintOdd")
                {
                    List<int> printOdd = new List<int>();
                    for (int i = 0; i < numbersMore.Count; i++)
                    {
                        if (numbersMore[i] % 2 != 0)
                        {
                            printOdd.Add(numbersMore[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", printOdd));
                }
                else if (tokens[0] == "GetSum")
                {
                    string sum = tokens[0];
                    int totalsum = numbersMore.Sum();
                    numbersMore.Sum();
                    Console.WriteLine(totalsum);
                }
                else if (tokens[0] == "Filter")
                {
                    string symbol = tokens[1];
                    int filter = int.Parse(tokens[2]);
                    if (symbol == "<")
                    {
                        Console.WriteLine(string.Join(" ", numbersMore.FindAll(x => x < filter)));
                    }
                    else if (symbol == ">")
                    {
                        Console.WriteLine(string.Join(" ", numbersMore.FindAll(x => x > filter)));
                    }
                    else if (symbol == ">=")
                    {
                        // result = numbersMore.Where(x => x >= filter).ToList();
                        Console.WriteLine(string.Join(" ", numbersMore.FindAll(x => x >= filter)));
                    }
                    else if (symbol == "<=")
                    {
                        Console.WriteLine(string.Join(" ", numbersMore.FindAll(x => x <= filter)));
                    }
                }
                else if (tokens[0] == "Add" || tokens[0] == "Remove" || tokens[0] == "RemoveAt" || tokens[0] == "Insert")
                {
                    Console.WriteLine(string.Join(" ", numbersMore));
                }
                command = Console.ReadLine();
            }
        }
    }
}
