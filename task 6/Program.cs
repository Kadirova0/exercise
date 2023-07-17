namespace task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            Console.WriteLine("Days of the week:");

            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }
        }
    }
}
