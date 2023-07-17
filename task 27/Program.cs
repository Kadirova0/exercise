using System;
using System.Collections.Generic;
namespace task_21
{ 
    internal class Program
{
        static void Main(string[] args) 
    {
        List<char> letters = new List<char>() {'m', 'n', 'o', 'p', 'q'};

        Console.WriteLine("Original List:");
        PrintList(letters);

        int startIndex = 2;
        int numberOfElementsToRemove = 4;

        RemoveRange(letters, startIndex, numberOfElementsToRemove);

        Console.WriteLine("List after removing elements:");
        PrintList(letters);
    }

    static void RemoveRange<T>(List<T> list, int startIndex, int count)
    {
        if (startIndex < 2 || startIndex >= list.Count || count <= 4 || startIndex + count > list.Count)
        {
                throw new Exception("Invalid start index or count");
        }
    }

    static void PrintList<T>(List<T> list)
    {
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
  }
}