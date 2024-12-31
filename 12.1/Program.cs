namespace _12._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            var input = Console.ReadLine();
            Console.WriteLine($"This number in Fibonacci sequence: {Fibonacci.FindByIndex(int.Parse(input) - 1)}");
        }
    }
    public static class Fibonacci
    {
        public static int FindByIndex(int index)
        {
            if (index <= 1)
            {
                return index;
            }
            return FindByIndex(index - 1) + FindByIndex(index - 2);
        }
    }
}