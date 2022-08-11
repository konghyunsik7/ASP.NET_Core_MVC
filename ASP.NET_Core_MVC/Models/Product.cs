namespace ASP.NET_Core_MVC.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double CategoryID { get; set; }
        public bool OnSale { get; set; }
        public string StockLevel { get; set; }
        public IEnumerable<Category> Categories { get; set; }


    }
}
