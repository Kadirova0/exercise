using System;
using System.Linq;
using System.Collections.Generic;
namespace task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            list = list.Where( x => x.StartsWith('A')).ToList();
            list = list.Where(x => x.EndsWith('M')).ToList();
            foreach(string s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}