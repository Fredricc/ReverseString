class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a string:");
        string name = Console.ReadLine();

        string reverseString = StringToReverse(name);
        Console.WriteLine(reverseString);
    }

    private static string StringToReverse(string? name)
    {
        string r = "";

        for (int i = name.Length - 1; i >= 0 ; i--)
        {
            r += name[i];
        }
        return r;
    }
}