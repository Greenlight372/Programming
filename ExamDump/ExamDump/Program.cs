public class Program
{
    private static void Main(string[] args)
    {
        int[] intArray = new int[] { 1, 2, 3, 4, 5, 6 };
        var sortedArray = intArray.Where(p => p % 2 == 0).OrderBy(p => p);

        foreach (int i in sortedArray)
            Console.WriteLine(i);

        Console.ReadLine();
    }
}