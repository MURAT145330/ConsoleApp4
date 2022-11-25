using Methotlar;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        Product product1 = new Product();
        product1.Id = 1;
        product1.Name = "elma";
        product1.UnitPrice = 17;
        product1.UnitIsStock = "amasya";


        Product product2 = new Product();
        product2.Id = 2;
        product2.Name = "leblebi";
        product2.UnitPrice = 25;
        product2.UnitIsStock = "corum";

        Product product3 = new Product();
        product3.Id = 3;
        product3.Name = "kangal";
        product3.UnitPrice = 10;

        Product[] products = new Product[] {};

        //for (var i = 0; i < products.Length; i++)
        //{
        //    Console.WriteLine(products[i]);
        //}

        foreach (var product in products)
        {
            Console.WriteLine(product.Name);
        }
        Console.WriteLine("**************************methotlar**");


        SepetManeger sepetManeger = new SepetManeger();
        sepetManeger.Add(product1);
       
    }
}