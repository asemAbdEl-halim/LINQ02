using LINQ02.DataSources;

namespace LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question01
            //var result1 = Source.ProductList
            //        .OrderByDescending(p => p.UnitPrice)
            //        .Take(3);

            //foreach (var p in result1)
            //{
            //    Console.WriteLine(p.ProductName + " - " + p.UnitPrice);
            //} 
            #endregion

            #region Question02

            //var result2 = Source.ProductList
            //    .Skip(5)
            //    .Take(5);

            //foreach (var p in result2)
            //{
            //    Console.WriteLine(p.ProductName);
            //}

            #endregion

            #region Question03

            //var result3 = Source.ProductList
            //    .OrderBy(p => p.UnitPrice)
            //    .TakeWhile(p => p.UnitPrice < 25);

            //foreach (var p in result3)
            //{
            //    Console.WriteLine(p.ProductName + " - " + p.UnitPrice);
            //}

            #endregion

            #region Question04

            //bool result4 = Source.ProductList
            //    .Where(p => p.Category == "Seafood")
            //    .All(p => p.UnitsInStock > 0);

            //Console.WriteLine(result4);

            #endregion

            #region Question05


            //int[] ids = { 3, 9, 13, 18 };

            //bool result5 = ids.Contains(9);

            //Console.WriteLine(result5);

            #endregion

            #region Question06

            //var result6 = Source.ProductList
            //   .GroupBy(p => p.Category);

            //foreach (var group in result6)
            //{
            //    Console.WriteLine(
            //        group.Key + " - Count: " +
            //        group.Count()
            //    );
            //}

            #endregion

            #region Question07

            //var result7 = Source.ProductList
            //     .GroupBy(
            //         p => p.Category,
            //         p => p.ProductName
            //     );

            //foreach (var group in result7)
            //{
            //    Console.WriteLine(group.Key);

            //    foreach (var name in group)
            //    {
            //        Console.WriteLine("  " + name);
            //    }
            //}

            #endregion

            #region Question08

            //var result8 = Source.ProductList
            //    .GroupBy(p => p.Category)
            //    .Where(group => group.Count() > 3);

            //foreach (var group in result8)
            //{
            //    Console.WriteLine(
            //        group.Key + " - " +
            //        group.Count()
            //    );
            //}

            #endregion

            #region Question09

            //var result9 =
            //     from c in Source.CustomerList
            //     group c by c.Country into countryGroup
            //     select new
            //     {
            //         Country = countryGroup.Key,
            //         Count = countryGroup.Count(),
            //         TotalOrderValue = countryGroup
            //             .SelectMany(c => c.Orders)
            //             .Sum(o => o.Total)
            //     };

            //foreach (var item in result9)
            //{
            //    Console.WriteLine(
            //        item.Country + " - Customers: " +
            //        item.Count + " - Total Order Value: " +
            //        item.TotalOrderValue
            //    );
            //}

            #endregion

            #region Question10

            //int result10 = Source.ProductList
            //    .Sum(p => p.UnitsInStock);

            //Console.WriteLine("Total Units in Stock: " + result10);

            #endregion

            #region Question11

            var cheapestPrice = Source.ProductList
                 .Min(p => p.UnitPrice);

            var mostExpensivePrice = Source.ProductList
                .Max(p => p.UnitPrice);

            Console.WriteLine("Cheapest Price: " + cheapestPrice);
            Console.WriteLine("Most Expensive Price: " + mostExpensivePrice);

            #endregion
        }
    }
}
