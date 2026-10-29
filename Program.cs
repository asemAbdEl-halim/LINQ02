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
        }
    }
}
