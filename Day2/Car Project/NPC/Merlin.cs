namespace NPC;

public class Merlin
{
    public string nameChar;
    public string townSpawn;

    public Merlin(string nameChar, string townSpawn)
    {
        this.nameChar = nameChar;
        this.townSpawn = townSpawn;
    }

    public void CommentNPC()
    {
        Console.WriteLine($"My name is {nameChar}, i lived in {townSpawn}");
    }
}