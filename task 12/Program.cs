using System;
using System.Linq;
namespace task_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "this IS a STRING";
            var uppercaseWords = sentence.Split(' ').Where(x => x.ToUpper);
            Console.WriteLine("Uppercase words in the string:");
            foreach (var word in uppercaseWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}