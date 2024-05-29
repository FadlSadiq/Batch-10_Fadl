using System.Collections;

class FB
{
    public List<string> Transform(int Numbers)
    {
        List<string> results = new List<string>();
        for (int i = 1; i <= Numbers; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                NewWords foobar = NewWords.FooBar;
                System.Console.WriteLine(foobar);
            }
            else if (i % 3 == 0)
            {
                NewWords foo = NewWords.Foo;
                System.Console.WriteLine(foo);
            }
            else if (i % 5 == 0)
            {
                NewWords bar = NewWords.Bar;
                System.Console.WriteLine(bar);
            }
            else
            {
                results.Add(i.ToString());
            }
        }
        return results;
    }
}