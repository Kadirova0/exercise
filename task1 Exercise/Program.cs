using System;
using System.Linq;
namespace task1_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var list = new List<int>() { 0, 1, 2, 4, 6, 7, 8, 15 };
            list = list.Where(x => x % 2 == 0).ToList();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}