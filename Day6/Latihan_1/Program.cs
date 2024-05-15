class Program
{
    public delegate string HumanHealth (string health);
    static void Main()
    {
            HumanHealth hp = (health) =>
            {
                return "testing " + health;
            }; // lambda expression
            string newhp = hp.Invoke("89");
            Console.WriteLine(newhp);
    }

}
