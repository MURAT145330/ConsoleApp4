internal class Program
{
    private static void Main(string[] args)
    {
        Product product = new Product();
        product.Id = 1;
        product.Name = "kiraz";
        product.SorName ="amasya";
        product.UnitPrice = 17;
        product.StockAmount = 1;
        Product product2 = new Product();
        product2.Id = 2;
        product2.Name = "elma";
        product2.SorName = "bursa";
        product2.UnitPrice = 20;
        product2.StockAmount = 2;

        Product product3 = new Product();
        product3.Id = 2;
        product3.Name = "armut";
        product3.SorName = "edirne";
        product3.UnitPrice = 23;
        product3.StockAmount = 3;

        List<Product> _products = new List<Product>();

        _products.Add(product);
        _products.Add(product2);
        _products.Add(product3);

        //foreach (var item in _products)
        //{
        //    Console.WriteLine(item.Name);
        //}
        for (var i = 0; i < _products.Count; i++)
        {
            Console.WriteLine(i);
        }
    }

    class Product
    {
        public int Id { get; set; }
        public string  Name{ get; set; }
        public String SorName { get; set; }
        public decimal UnitPrice { get; set; }
        public int StockAmount { get; set; }
    }



}