class Program
{
    static void Main()
    {
        using (FileStream fs = new("file.txt", FileMode.Create, FileAccess.Write))
        {
            string[] input = { "Saya adalah manusia", "yang hidup di dunia", "Fana ini" };
            using (StreamWriter outputFile = new StreamWriter(fs))
            {
                foreach (var word in input)
                {
                    outputFile.WriteLine(word);
                }
            }
        }

        using (FileStream fs = new("file.txt", FileMode.Append, FileAccess.Write))
        {
            using (StreamWriter outputFile = new(fs))
            {
                outputFile.WriteLine("Tapi saya suka makan bakso");
            }
        }

        using (StreamReader inputFile = new("file.txt"))
        {
            System.Console.WriteLine(inputFile.ReadLine());
            System.Console.WriteLine(inputFile.ReadLine());
            System.Console.WriteLine(inputFile.ReadLine());
            System.Console.WriteLine(inputFile.ReadLine());
        }
    }
}