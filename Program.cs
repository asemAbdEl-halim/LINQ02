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

            var result2 = Source.ProductList
                .Skip(5)
                .Take(5);
                
            foreach (var p in result2)
            {
                Console.WriteLine(p.ProductName);
            }

            #endregion
        }
    }
}
