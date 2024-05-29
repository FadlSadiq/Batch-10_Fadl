using System.Xml.Serialization;

public class Human
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }

    public Human()
    { }

    public Human(string name, int age, string address)
    {
        Name = name;
        Age = age;
        Address = address;
    }
}

class Program
{
    static void Main()
    {
        Human yusa = new Human("Yusa", 26, "Tulungagung");
        Human ega = new Human("Ega", 22, "Semarang");
        Human rizky = new Human("Rizqi", 24, "Bandung");
        Human fadl = new Human("Fadl", 22, "Jakarta");
        Human dewi = new Human("Dewi", 25, "Pati");
        Human wulan = new Human("Wulan", 29, "Bandung");
        Human bela = new Human("Bela", 24, "Kediri");
        Human jun = new Human("Jun", 23, "Balikpapan");

        string name = Console.ReadLine();
        int age = Convert.ToInt32(Console.ReadLine());
        string address = Console.ReadLine();
        Human user = new Human(name, age, address);

        List<Human> bootcamp = new List<Human>
        {
            yusa, ega, rizky, fadl, dewi, wulan, bela, jun, user
        };

        XmlSerializer xmlSerializer = new(typeof(List<Human>));
        using(StreamWriter sw = new("file.xml"))
        {
            xmlSerializer.Serialize(sw, bootcamp);
        }
    }
}