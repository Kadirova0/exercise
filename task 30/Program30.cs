using System;
using System.Linq;
namespace task_30
{
    internal class Program30
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "Biscuit", "Brade", "Butter", "Honey" };
            list = list.OrderBy(x => x).ToList();
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}