namespace Interface;
public interface IHero
{
    public Guid HeroId{get;}
    public string HeroName{get;}
    public Hero Copy();
}