using Matemetik;

public class Program
{
    private static void Main(string[] args)
    {
        //   Console.WriteLine("Hello, World!");


        DortIslem dortIslem = new DortIslem();

        dortIslem.Topla(6,6);
        Console.WriteLine("***********");

        var result=  dortIslem.Carp(6,6);
        Console.WriteLine(result);

    }
}