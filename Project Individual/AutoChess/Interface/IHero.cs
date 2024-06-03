namespace Interface;
public interface IHero
{
    public int HeroId{get;}
    public string HeroName{get;}
    public Hero Copy();
}