using Interface;
public class Hero : IHero
{
    public Guid HeroId {get; private set;}
    public string HeroName {get; private set;}

    public Hero(string heroName)
    {
        HeroId = new Guid();
        HeroName = heroName;
    }

    public Hero Copy()
    {
        return (Hero) this.MemberwiseClone();
    }
}
