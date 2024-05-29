class Hero : IHero
{
    public int HeroId {get; private set;}
    public string HeroName {get; private set;}

    public Hero(int heroId, string heroName)
    {
        HeroId = heroId;
        HeroName = heroName;
    }

    public Hero Copy()
    {
        Hero HeroClone = (Hero) this
    }
}