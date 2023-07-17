using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace task_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\fatim\OneDrive\Masaüstü\fatima qadirova.txt";
            byte[] text = File.ReadAllBytes(path);

            Console.WriteLine(text);
        }
    }
}