

class Test
{
    static void Main(string[] args)
    {
        string val1 = "ChildCat";
        string val2 = val1;
        val2 = "CatMom";

        Console.WriteLine ($"val1 id {val1} && val2 is {val2}");
    }
}