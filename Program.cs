namespace GenericsPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Find Maximum numer Problem");

            int intVariable1 = 100;
            int intVariable2 = 200;
            int intVariable3 = 300;
            MaximumNum<int> maximumInt = new MaximumNum<int>(intVariable1, intVariable2, intVariable3);
            Console.WriteLine("Maximum value for integers: " + maximumInt.TestMaximum());

            double doubleVariable1 = 435.3;
            double doubleVariable2 = 12.4;
            double doubleVariable3 = 187.45;
            MaximumNum<double> maximumDouble = new MaximumNum<double>(doubleVariable1, doubleVariable2, doubleVariable3);
            Console.WriteLine("Maximum value for doubles: " + maximumDouble.TestMaximum());

            string stringVariable1 = "Red";
            string stringVariable2 = "Black";
            string stringVariable3 = "Orange";
            MaximumNum<string> maximumString = new MaximumNum<string>(stringVariable1, stringVariable2, stringVariable3);
            Console.WriteLine("Maximum value for strings: " + maximumString.TestMaximum());
        }
    }
   
}