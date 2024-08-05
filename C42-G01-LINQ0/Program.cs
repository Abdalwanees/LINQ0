using C42_G01_LINQ0.classes;

namespace C42_G01_LINQ0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators

            #region 1. Find all products that are out of stock.

            //// fluent syntax
            //var Result = ListGenerator.ProductList.Where(p => p.UnitsInStock != 0);
            ////Quary syntax
            //Result = from p in ListGenerator.ProductList
            //         where p.UnitsInStock != 0
            //         select p;

            //Console.WriteLine("-*-*-*-*-*-*-*--**-*-*-*-*-*-");
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 2. Find all products that are in stock and cost more than 3.00 per unit.
            //// fluent syntax 
            //var Result02 = ListGenerator.ProductList.Where(p => p.UnitsInStock != 0 && p.UnitPrice > 3.00M);
            ////Quary syntax
            //Result02=from p in ListGenerator.ProductList
            //         where p.UnitsInStock != 0 &&p.UnitPrice>3.00M
            //         select p;
            //Console.WriteLine("-*-*-*-*-*-*-*--**-*-*-*-*-*-");
            //foreach (var item in Result02)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 3. Returns digits whose name is shorter than their value.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //// Fluent syntax to filter names whose length is shorter than the digit value
            //var Result03 = Arr
            //    .Select((name, index) => new { Name = name, Value = index })
            //    .Where(x => x.Name.Length < x.Value)
            //    .Select(x => x.Name);

            //// Print the result in the desired format
            //foreach (var item in Result03)
            //{
            //    Console.Write($"\"{item}\", ");
            //}

            #endregion

            #endregion

            #region LINQ - Ordering Operators

            #region 1. Sort a list of products by name

            #region Sort Accending

            //var Result04 = ListGenerator.ProductList.OrderBy(p => p.ProductName);

            //Result04 = from p in ListGenerator.ProductList
            //           orderby p.ProductName
            //           select p;
            //Console.WriteLine("-*-*-*-*-*-*-*--**-*-*-*-*-*-");
            //foreach (var item in Result04)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region sort Descending

            //var Result05 = ListGenerator.ProductList.OrderByDescending(p => p.ProductName);

            //Result05 = from p in ListGenerator.ProductList
            //           orderby p.ProductName descending
            //           select p;
            //Console.WriteLine("-*-*-*-*-*-*-*--**-*-*-*-*-*-");
            //foreach (var item in Result05)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #endregion

            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //IEnumerable<string> sortedArr = Arr.OrderBy(word => word, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in sortedArr)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 3. Sort a list of products by units in stock from highest to lowest.
            ////Fluent Syntax
            //var Result06 = ListGenerator.ProductList.OrderByDescending(p => p.UnitsInStock);
            ////Quary syntax
            //Result06 =from p in ListGenerator.ProductList
            //          orderby p.UnitsInStock descending
            //          select p;
            //Console.WriteLine("-*-*-*-*-*-*-*--**-*-*-*-*-*-");
            //foreach (var item in Result06)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Result07 = Arr
            //    .OrderBy(name => name.Length)
            //    .ThenBy(name => name);

            //foreach (var item in Result07)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 5. Sort first by word length and then by a case-insensitive sort of the words in an array.
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };


            //var Result08 = words
            //    .OrderBy(word => word.Length)
            //    .ThenBy(word => word, StringComparer.OrdinalIgnoreCase);
            //foreach (var word in Result08)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion

            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            // //Fluent Syntax
            // var Result09 = ListGenerator.ProductList.OrderByDescending(p => p.Category).ThenByDescending(p => p.UnitPrice);
            ////Query syntax
            //Result09=from p in ListGenerator.ProductList
            //         orderby p.Category,p.UnitPrice descending
            //         select p;
            // Console.WriteLine("-*-*-*-*-*-*-*--**-*-*-*-*-*-");
            // foreach (var item in Result09)
            // {
            //     Console.WriteLine(item);
            // }

            #endregion

            #region 7. Sort first by word length and then by a case-insensitive descending sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var Result10 = Arr
            //    .OrderBy(word => word.Length)
            //    .ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase);

            //Console.WriteLine("-*-*-*-*-*-*-*--**-*-*-*-*-*-");
            //foreach (var item in Result10)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Result11 = Arr
            //    .Where(word => word.Length > 1 && word[1] == 'i')
            //    .Reverse();
            //foreach (var item in Result11)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion

        }
    }
}
