class Program
{
    static void Main()
    {
        List<string> files = new List<string>();
        string directoryPath = @"C:\Users\roma1\source\repos\lab3oop\lab3oop";
        for (int i = 10; i <= 29; i++)
        {
            string fileName = $"{i}.txt";
            string filePath = Path.Combine(directoryPath, fileName);
            files.Add(filePath);

        }
        List<string> noFile = new List<string>();
        List<string> badData = new List<string>();
        List<string> overflow = new List<string>();
        List<int> validProducts = new List<int>();
    }
}