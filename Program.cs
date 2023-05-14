namespace GenericsPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Find Maximum numer Problem");

            int[] intArray = { 100, 200, 300 };
            MaximumNum<int> maximum = new MaximumNum<int>(intArray);
            maximum.PrintMaxVlue();
        }
    }
}