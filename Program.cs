// *****************************************Method Hiding**********************************************
//using System;

//public class Employee
//{
//    public string FirstName;
//    public string LastName;

//    public void PrintFullName()
//    {
//        Console.WriteLine(FirstName + " " + LastName);
//    }
//}
//public class PartTimeEmployee : Employee
//{
//    public new void PrintFullName()
//    {
//        // still if we want to use the Base class methos then : Base.PrintFullName(); we can call here...
//        Console.WriteLine(FirstName + " " + LastName + " - Contractor");
//    }
//}
//public class FullTimeEmployee : Employee
//{

//}

//public class Program
//{
//    public static void Main()
//    {
//        FullTimeEmployee FTE = new FullTimeEmployee();
//        FTE.FirstName = "FullTime";
//        FTE.LastName = "Employee";
//        FTE.PrintFullName();

//        PartTimeEmployee PTE = new PartTimeEmployee();
//        PTE.FirstName = "PartTime";
//        PTE.LastName = "Employee";
//        PTE.PrintFullName();
//        // ((Employee)PTE).PrintFullName(); To get the hiddin method of the base class



//    }
//}


//******************************************* LambdaExpression**************************
//using System.Globalization;

//namespace LambdaExpression
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // args =>(Goes to) expression : Lambda Expression
//            //Number => Number * Number
//            // () => ...
//            // (x,y,z) => ...
//            //Func<int, int> square = number => number*number; // Syntax for Lambda Expression
//            //int x = Convert.ToInt32(Console.ReadLine());
//            //Console.WriteLine(square(x));



//        }

//        //static int square(int x)
//        //{
//        //    return x*x;
//        //}
//    }
//}

//*********** Example of Lambda Expression ************************
//using System;
//using System.Collections.Generic;

//namespace LambdaExpression
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var books = new BookRepository().GetBooks();

//            // Using Lambda Expression to filter books cheaper than $10
//            var cheapBooks = books.FindAll(book => book.Price < 10);

//            foreach (var book in cheapBooks)
//            {
//                Console.WriteLine(book.Title + " - $" + book.Price);
//            }
//        }
//    }

//    public class Book
//    {
//        public string Title { get; set; }
//        public decimal Price { get; set; }
//    }

//    public class BookRepository
//    {
//        public List<Book> GetBooks()
//        {
//            return new List<Book>
//            {
//                new Book() {Title = "Title 1", Price = 5},
//                new Book() {Title = "Title 2", Price = 7},
//                new Book() {Title = "Title 3", Price = 17}
//            };
//        }
//    }
//}
