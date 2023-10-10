class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter your name that will be printed");
        string name = Console.ReadLine();

        string reverseString = StringToReverse(name);
        Console.WriteLine($"There reverse of {name} is {reverseString}");
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