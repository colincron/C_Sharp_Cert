// https://learn.microsoft.com/en-us/training/modules/csharp-arrays/

internal class Program
{
    private static void Main(string[] args)
    {
        string[] fraudulentOrderIDs = {"A123", "B456", "C789"};

        System.Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
        System.Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
        System.Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

        fraudulentOrderIDs[0] = "F000";

        System.Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

        System.Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
    }
}