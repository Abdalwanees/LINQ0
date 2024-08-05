using Demo.Classes;
using Demo.Integer_Extentions;
using System.Globalization;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implicitly type local variable
            //var name1 = "Ahmed"; //-->Compiler will detect the variable datatype 
            ////name1 = 10;//not allowed detected datatype to string
            ////var name1;//not allowed compile can not detect datatype

            //dynamic name2="ali";//CLR detect the variable datatype at RunTime based on last initialized

            #endregion

            #region Extention Methods
            //int x = 123;
            //x=x.Reverse();
            //Console.WriteLine(x);
            #endregion

            #region Annonuyous Type -->Var
            //var employee = new { Id = 1, Name = "Foo", Salary = 5000 };
            ////Console.WriteLine(employee.Id);
            ////Console.WriteLine(employee.Name);
            ////Console.WriteLine(employee.Salary);
            //////craete class name [annonumous0`3] take 3 parameter and overide method toString()
            ////employee = new { Id = 2, Name = "Bar", Salary = 1000 };
            //var employee02 = new { Id = 3, Name = "Bar", Salary = 1000 };
            ////Console.WriteLine(employee.GetType());
            ////Console.WriteLine(employee02.GetType());
            ////// Annonumous  type is genaric
            //////Annonumous type is immutable -->we Can not modify any property
            //////Annonumous type is case senisitive



            #endregion

            #region LINQ
            ////Linq -->stands for language indegrated Quary 
            //// +40 method with thir overloads
            //List<int> Numbres = new List<int>()
            //{1,2,3,4,5,6,7,8,9,10,1,11,2,4,5,6,8 };
            ////You  can use "Linq aperatores " againist data 
            ////[Stored in sequance] regardless the sourece of data (SQL,MYSQL,Oracle)

            ////1. Local --> L2O ,L2XML

            ////2. Remote --> L2EF


            //List<int> OddNum=Numbres.Where(x => x%2!=0).ToList();// We use ToList() --> where() return data from IEnumerable
            //foreach (var item in OddNum)
            //{
            //    Console.Write(item);
            //}

            //Console.WriteLine("\n-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            //for (int i=0;i<OddNum.Count;i++)
            //{
            //    Console.Write(OddNum[i]);
            //}
            //var OddNum01 = Numbres.Where(x => x % 2 != 0);
            //Console.WriteLine("\n-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            //foreach (var item in OddNum01)
            //{
            //    Console.Write(item);
            //}
            ////Console.WriteLine("\n-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            ////for (int i = 0; i < OddNum01.length; i++)
            ////{
            ////    Console.Write(OddNum01[i]);
            ////}

            #endregion

            #region LINQ Syntax
            //List<int> Numbres = new List<int>()
            //{1,2,3,4,5,6,7,8,9,10,1,11,2,4,5,6,8 };
            ////Fluent Syntax  (C# Syntax)
            //// 01. Use LINQ Operartor as => static method through 
            //var OddNum = Enumerable.Where(Numbres, x => x % 2 != 0);
            //foreach (var item in OddNum)
            //{
            //    Console.Write($"{item} ");
            //}
            //// 02. use LINQ Operator as extention methods
            //Console.WriteLine("\n-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-\n");
            //var OddNum01 = Numbres.Where(x => x % 2 != 0);
            //foreach (var item in OddNum01)
            //{
            //    Console.Write($"{item} ");
            //}

            ////Query Syntax  (Sql Syntax)
            //Console.WriteLine("\n-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-\n");

            //var OddNum02 = from n in Numbres 
            //              where (n%2!=0) 
            //              select n;
            //foreach (var item in OddNum02)
            //{
            //    Console.Write($"{item} ");
            //}
            #endregion

            #region LINQ Excution
            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 11, 2, 4, 5, 6, 8 };

            //// 01. Immediate Execution (Element operator, Casting Operator, Aggregate operator)

            //// Element Operator: First
            //var firstNumber = Numbers.First();
            //Console.WriteLine("First Number: " + firstNumber);

            //// Casting Operator: ToArray
            //var numbersArray = Numbers.ToArray();
            //Console.WriteLine("Numbers Array: " + string.Join(", ", numbersArray));

            //// Aggregate Operator: Sum
            //var sumOfNumbers = Numbers.Sum();
            //Console.WriteLine("Sum of Numbers: " + sumOfNumbers);

            //// 02. Deferred Execution (10 categories)

            //// Filtering Operator: Where
            //var OddNum = Numbers.Where(x => x % 2 != 0);

            //// Initial iteration over deferred query
            //Console.WriteLine("Odd Numbers initially:");
            //foreach (var item in OddNum)
            //{
            //    Console.Write($" {item} ");
            //}
            //Console.WriteLine();

            //// Modify the collection
            //Numbers.AddRange(new int[] { 11, 2, 5, 9, 8, 7, 5, 6, 2, 1, 7, 56, 6, 5 });

            //// Iteration over deferred query after modification
            //Console.WriteLine("Odd Numbers after modification:");
            //foreach (var item in OddNum)
            //{
            //    Console.Write($" {item} ");
            //}
            //Console.WriteLine();
            #endregion

            #region LINQ Categories

            #region Filteration [Restriction] (Where)

            ////Fluent Expression
            //var Result = ListGenerator.ProductList.Where(p => p.UnitsInStock == 0);
            //Console.WriteLine("-*-*-*-*-*-*-*--**-*-*-*-*-*-");
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            //// Quary Expressin
            //Result = from p in ListGenerator.ProductList
            //         where p.UnitsInStock == 0
            //         select p;
            //Console.WriteLine("-*-*-*-*-*-*-*--**-*-*-*-*-*-");
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}



            ////Fluent Expression

            //var Result01 = ListGenerator.ProductList.Where(p => p.UnitsInStock == 0 && p.Category == "Meat/Poultry");
            //Console.WriteLine("-*-*-*-*-*-*-*--**-*-*-*-*-*-");
            //foreach (var item in Result01)
            //{
            //    Console.WriteLine(item);
            //}

            //// Quary Expressin 
            //Result01 = from p in ListGenerator.ProductList
            //           where p.UnitsInStock == 0 && p.Category == "Meat/Poultry"
            //           select p;
            //Console.WriteLine("-*-*-*-*-*-*-*--**-*-*-*-*-*-");
            //foreach (var item in Result01)
            //{
            //    Console.WriteLine(item);
            //}

            //// indexed where can write only with Fluent Expression
            //Result = ListGenerator.ProductList.Where((P, I) => I < 10 && P.UnitsInStock == 0);
            //Console.WriteLine("-*-*-*-*-*-*-*--**-*-*-*-*-*-");
            //foreach (var item in Result01)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Ordering Operator
            ////OrderBy Accinding

            ////Fluent Syntax
            //var Result = ListGenerator.ProductList.OrderBy(p => p.UnitsInStock);
            //Console.WriteLine("-*-*-*-*-*-*-*--**-*-*-*-*-*-");
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            ////Query Syntax
            //Result =from p in ListGenerator.ProductList
            //       orderby p.UnitsInStock
            //       select p;
            //Console.WriteLine("-*-*-*-*-*-*-*--**-*-*-*-*-*-");
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            ////OrderBy Descending
            ////Fluent Syntax
            //var Result01 = ListGenerator.ProductList.OrderByDescending(p => p.UnitsInStock);
            //Console.WriteLine("-*-*-*-*-*-*-*--**-*-*-*-*-*-");
            //foreach (var item in Result01)
            //{
            //    Console.WriteLine(item);
            //}

            ////Query Syntax
            //Result01 =from p in ListGenerator.ProductList
            //       orderby  p.UnitsInStock descending
            //       select p;
            //Console.WriteLine("-*-*-*-*-*-*-*--**-*-*-*-*-*-");
            //foreach (var item in Result01)
            //{
            //    Console.WriteLine(item);
            //}


            ////OrderBy then
            ////Fluent Syntax
            //var Result02 = ListGenerator.ProductList.OrderBy(p => p.UnitsInStock).ThenBy(p=>p.ProductID);
            //Console.WriteLine("-*-*-*-*-*-*-*--**-*-*-*-*-*-");
            //foreach (var item in Result02)
            //{
            //    Console.WriteLine(item);
            //}

            ////Query Syntax
            //Result02 =from p in ListGenerator.ProductList
            //       orderby  p.UnitsInStock, p.ProductID
            //       select p;
            //Console.WriteLine("-*-*-*-*-*-*-*--**-*-*-*-*-*-");
            //foreach (var item in Result02)
            //{
            //    Console.WriteLine(item);
            //}


            //Reverse
            var Result03 = ListGenerator.ProductList.Where(p => p.UnitsInStock==0);
            Console.WriteLine("-*-*-*-*-*-*-*--**-*-*-*-*-*-");
            foreach (var item in Result03)
            {
                Console.WriteLine(item);
            }
            Result03= ListGenerator.ProductList.Where(p => p.UnitsInStock == 0).Reverse();
            Console.WriteLine("-*-*-*-*-*-*-*--**-*-*-*-*-*-");
            foreach (var item in Result03)
            {
                Console.WriteLine(item);
            }

            #endregion

            #endregion


        }
    }
}
