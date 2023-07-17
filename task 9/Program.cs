using System;
using System.Linq;
using System.Collections.Generic;
namespace task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 55, 200, 740, 76, 230, 482, 95};
            list .Sort();
            list = list.Where(x => x > 80).ToList();
            foreach (int x in list)
            {
                Console.WriteLine(x);
            }
        }
    }
}