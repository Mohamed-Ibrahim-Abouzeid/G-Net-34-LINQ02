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
            #region Q4
            //bool allSeafoodInStock = products
            //.Where(p => p.Category == "Seafood")
            //.All(p => p.UnitsInStock > 0);
            #endregion
            #region Q5
            //int[] ids = { 3, 9, 13, 18 };
            //bool contains9 = ids.Contains(9);
            #endregion
            #region Q6
            //var groupCount = products.GroupBy(p => p.Category)
            //                     .Select(g => new
            //                     {
            //                         Category = g.Key,
            //                         Count = g.Count()
            //                     });

            #endregion
            #region Q7
            //var groupNames = products.GroupBy(p => p.Category)
            //                   .Select(g => new
            //                   {
            //                       Category = g.Key,
            //                       Names = g.Select(p => p.ProductName)
            //                   });
            #endregion
            #region Q8
            //var categoriesMoreThan3 = products.GroupBy(p => p.Category)
            //                              .Where(g => g.Count() > 3)
            //                              .Select(g => g.Key);
            #endregion
            #region Q9
            // var customerGroups =
            //from c in customers
            //group c by c.Country into g
            //select new
            //{
            //    Country = g.Key,
            //    Count = g.Count(),
            //    TotalOrderValue = g.Sum(c => c.TotalOrders)
            //};
            #endregion
            #region Q10
            //int totalUnits = products.Sum(p => p.UnitsInStock);
            #endregion
            #region Q11
            //var minPrice = products.Min(p => p.UnitPrice);
            //var maxPrice = products.Max(p => p.UnitPrice);
            #endregion
            #region Q12
            //var distinctCategories = products.Select(p => p.Category)
            //                            .Distinct();
            #endregion
            #region Q13
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var diff = setA.Except(setB);
            #endregion
            #region Q14
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var countriesDiff = list1.Except(list2, StringComparer.OrdinalIgnoreCase);

            #endregion
            #region Q15
            //var dict = products.ToDictionary(p => p.ProductID);
            //var product18 = dict.ContainsKey(18) ? dict[18] : null;
            #endregion
        }
    }
}
