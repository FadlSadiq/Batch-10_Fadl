class Program{
    static void Main(){
        // File name
        string fileName = "file.txt";

        FileManager fm = new();
        fm.Write(fileName, "Aku ingin liburan", 8);
        // System.Console.WriteLine(fm.ReadLine(fileName));
    }
}
class FileManager{
    public void Write(string path, string message, int number)
    {
        using (StreamWriter stream = new(path))
        {
            stream.WriteLine(message + " " + number);
        }
    }
    public string ReadLine(string path)
    {
        string result;
        using (StreamReader stream = new(path))
        {
            result = stream.ReadLine();
        }
        return result;
    }
}