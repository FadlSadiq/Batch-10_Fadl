class NPC
{
    // private int ID; // Field
    // int IDd{get; set;} // Properties

    // Properties
    public string Hair {private get;set;}
    public void ModifyHair(string npc)
    {
        Hair = npc;
    }
    public void GetHair(string npc)
    {
        Hair = npc;
    }
}

class Program
{
    static void Main()
    {
        NPC npc = new();
        npc.ModifyHair("spiky");
        //Console.WriteLine(npc.Hair);
        npc.GetHair("");
    }
}