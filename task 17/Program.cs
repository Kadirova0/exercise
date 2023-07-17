 using System;
 using System.Collections.Generic;
namespace task_17
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> letters = new List<char>() {'m', 'n', 'o', 'p', 'q'};

            Console.WriteLine("Original List:");
            PrintList(letters);

            char itemToRemove = 'o' ;
            RemoveItem(letters, itemToRemove);

            Console.WriteLine("List after removing element:");
            PrintList(letters);
        }

        static void RemoveItem<T>(List<T> list, T item)
        {
            list.Remove(item);
        }

        static void PrintList<T>(List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }

}