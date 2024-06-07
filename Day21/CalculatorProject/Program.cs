namespace CalculatorLib;

public class CalculatorIsNotFun
{
    static void Main()
    {

    }
    public int AddNumber(int x, int y)
    {
        return x + y;
    }

    public int MultiplyNumber(int x, int y)
    {
        return x * y;
    }

    public string Reverse(string Text)
    {
        string result = "";
        for(int i = Text.Length-1; i >= 0; i--)
        {
            result += Text[i];
        }
        return result;
    }
}

public class Person
{
    public string FirstName{get; set;}
    public string LastName{get; set;}
    public string GetFullName(Person person)
    {
        if(person == null) return null;
        return $"{person.FirstName} {person.LastName}";
    }
}