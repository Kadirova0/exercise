using System;
using System.Linq;
using System.Collections.Generic;
namespace task28
{
    internal class Program
    {
        static void Main(string[] args)
        {
         List<string> list = new List<string> {"Rome", "Paris", "London", "Zurich", "Nairobi", "Abu Dhabi", "Amsterdam", " New Delhi", "California"};
         list = list.Where(x=> x.Length > 0).ToList();
            foreach(string s in list)
            {
                Console.WriteLine(s);
            }
            list = list.OrderBy(x => x).ToList();
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}