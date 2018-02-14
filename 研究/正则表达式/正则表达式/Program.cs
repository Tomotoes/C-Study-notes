using System;
using System.Text.RegularExpressions;
class Test
{
    static void Main()
    {
        string pattern = "[Bbw]ill";
        string s = "My friend Bill will pay the bill";

        if (Regex.IsMatch(s, pattern))
            Console.WriteLine(s + "与" + pattern + "相匹配");

        Regex rx = new Regex(pattern);

        MatchCollection mc = rx.Matches(s);
        Console.WriteLine("有{0}次匹配", mc.Count);
        foreach (Match mt in mc)
        {
            Console.WriteLine(mt);
        }

        Match m = rx.Match(s);
        while (m.Success)
        {
            Console.WriteLine("在位置 {0} 有匹配'{1}'",
                m.Index, m.Value);
            m = rx.Match(s, m.Index + m.Length);
        }

        for (m = rx.Match(s); m.Success; m = m.NextMatch())
        {
            Console.WriteLine("在位置 {0} 有匹配'{1}'",
                m.Index, m.Value);
        }
        Console.WriteLine(string.Format("---------------------"));
        string Ac = @"m+abc?";
        Regex A = new Regex(Ac);
        if (A.IsMatch("mmmabc"))
        {
            Console.WriteLine("1");
        }
        Match B = A.Match("mabcmabc");
        while(B.Success)
        {
            Console.WriteLine("1");
            B = B.NextMatch();
        }
        Console.WriteLine(string.Format("---------------------"));
        string C = @"^[\.a-zA-Z]+ (?<Name>\w+), [a-zA-Z]+, x(?<Num>f+)$";
        string[] sa =
        {
            "Dr. David Jones, oasddwkcf, x123",
            "Dr. Simon Jones, oasddwkcf, x456",
        };
        Regex Q = new Regex(C);
        foreach (string It in sa)
        {
            Match AB = Q.Match(It);
            if (AB.Success)
            {
                Console.WriteLine(AB.Result("${Name},${Num},$1"));
            }
            Q.Replace(s, "姓：${Name}");
        }
      
    }
}
