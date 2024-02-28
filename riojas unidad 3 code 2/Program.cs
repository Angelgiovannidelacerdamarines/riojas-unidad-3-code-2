using System;

class RandomStringGenerator
{
    private int stringLength;

    // Constructor to initialize with random data
    public RandomStringGenerator()
    {
        Random random = new Random();
        stringLength = random.Next(5, 15);
        Console.WriteLine($"Random data generated: String Length={stringLength}");
    }

    // Generate a random string
    public string GenerateString()
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        Random random = new Random();
        return new string(Enumerable.Repeat(chars, stringLength)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of RandomStringGenerator
        RandomStringGenerator stringGenerator = new RandomStringGenerator();

        // Generate a random string and display
        Console.WriteLine($"Random String: {stringGenerator.GenerateString()}");
    }
}
