namespace ConsoleApp19
{
    class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
    class Customer
    {
        public string CompanyName { get; set; }
        public string Country { get; set; }
        public decimal TotalOrders { get; set; }
    }
    static class SampleData
    {
        public static List<Product> GetProducts() => new List<Product>
    {
        new Product { ProductID = 1, ProductName = "A", Category = "Food", UnitPrice = 10, UnitsInStock = 5 },
        new Product { ProductID = 2, ProductName = "B", Category = "Seafood", UnitPrice = 60, UnitsInStock = 3 },
        new Product { ProductID = 18, ProductName = "C", Category = "Seafood", UnitPrice = 20, UnitsInStock = 0 },
        new Product { ProductID = 4, ProductName = "D", Category = "Drinks", UnitPrice = 80, UnitsInStock = 10 },
        new Product { ProductID = 5, ProductName = "E", Category = "Food", UnitPrice = 15, UnitsInStock = 8 },
        new Product { ProductID = 6, ProductName = "F", Category = "Food", UnitPrice = 5, UnitsInStock = 20 },
    };

        public static List<Customer> GetCustomers() => new List<Customer>
    {
        new Customer { CompanyName = "Comp1", Country = "Germany", TotalOrders = 100 },
        new Customer { CompanyName = "Comp2", Country = "France", TotalOrders = 200 },
        new Customer { CompanyName = "Comp3", Country = "Germany", TotalOrders = 150 },
        new Customer { CompanyName = "Comp4", Country = "UK", TotalOrders = 50 },
    };
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = SampleData.GetProducts();
            List<Customer> customers = SampleData.GetCustomers();
            #region Q1
            //var top3 = products.OrderByDescending(p => p.UnitPrice).Take(3);
            #endregion
            #region Q2
            //var page2 = products.Skip(5).Take(5);
            #endregion
            #region Q3
            //var less25 = products.OrderBy(p => p.UnitPrice)
            //                 .TakeWhile(p => p.UnitPrice < 25);
            #endregion
        }
    }
}
