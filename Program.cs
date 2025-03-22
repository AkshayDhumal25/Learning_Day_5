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


//using System;
//using System.Text.Json;
//namespace DemoApp
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Product product = new Product
//            {
//                Id = 1,
//                Name = "Test",
//                InStock = true,
//                InventoryDate = DateTime.Now,
//                Price = 240.5M
//            };

//             string json = JsonSerializer.Serialize(product, new JsonSerializerOptions { WriteIndented = true});
//            Console.WriteLine(json);

//            Product newProduct = JsonSerializer.Deserialize<Product>(json);
//        }
//    }

//    public class Product
//    {
//        public int Id { get; set;}
//        public string Name { get; set;}

//        public bool InStock {  get; set;}

//        public decimal Price { get; set;}

//        public DateTime InventoryDate { get; set;}

//        //public int Price { get; set;}

//    }
//}


//****************** Logicals******************

//1.WAP to find Second largest element in an array : arr[] = [12, 35, 1, 10, 34, 1, 35], without
//sorting, without using any built-in methods and without deleting duplicate elements. What will be
//the time complexity?
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int[] array = new int[7] { 12, 35, 1, 10, 34, 1, 35 };
//            var secLarge = FindLarge(array);
//            Console.WriteLine(secLarge);
//        }
//        public static int FindLarge(int[] array)
//        {
//            var large = 0;
//            var secLarge = 0;
//            foreach(var i in array)
//            {
//                if (i > large)
//                {
//                    secLarge = large;
//                    large = i;
//                }
//                if (i  < large && i > secLarge)
//                {
//                    secLarge = i;
//                }
//            }
//            return secLarge;
//        }
//    }
//}


//2.WAP to reverse an integer without converting it to a string, without using any built-in methods.

//using System;
//namespace logicals
//{
//    class Pragram
//    {
//        public static void Main(string[] args)
//        {
//            int n = Convert.ToInt32(Console.ReadLine());
//            var reverseNum = new List<int>();
//            while (n > 0)
//            {
//                reverseNum.Add(n % 10);
//                n = n / 10;
//            }
//            foreach(int i in reverseNum)
//            {
//                Console.Write(i);
//            }

//        }
//    }
//}

// 3.Swap Values without using any variable a = 10, b = 12.
//using System;
//namespace logicals
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int a = 10;
//            int b = 12;

//            a = a + b; // 10 + 12 = 22
//            b = a - b; // 22 - 12 = 10
//            a = a - b; // 22 - 12 = 10

//            Console.WriteLine($"A: {a}, B: {b}");
//        }
//    }
//}


//4.Logic for anagram program with its time complexity. (for large strings).
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static bool checkAnagram(string str1, string str2)
//        {
//            if(str1.Length != str2.Length)
//            {
//                return false;
//            }

//            int[] charCount = new int[256];
//            for(int i = 0; i < str1.Length; i++)
//            {
//                charCount[str1[i]]++;
//                charCount[str2[i]]--;
//            }

//            foreach(var count in charCount)
//            {
//                if(count != 0)
//                {
//                    return false;

//                }
//            }
//            return true;
//        }
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the String 1 : ");
//            var str1 = Console.ReadLine();
//            Console.WriteLine("Enter the String 2 : ");
//            var str2 = Console.ReadLine();

//            if (checkAnagram(str1, str2))
//            {
//                Console.WriteLine("Strings are Anagrams.");
//            }
//            else
//            {
//                Console.WriteLine("Not Anagrams");
//            }
//        }

//    }
//}

//4.Find the reverse of the string.
//using System;
//namespace logicals
//{
//    class program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the string :");
//            var str = Console.ReadLine();
//            var reverse = new List<char>(str.Length);
//            for(var i = str.Length-1; i >= 0; i--)
//            {
//                reverse.Add(str[i]);
//            }
//            foreach(var i in reverse)
//            {
//                Console.Write(i);
//            }
//        }
//    }
//}

//5.WAP to find missing elements from the array?
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(String[] args)
//        {
//            int[] numbers = new int[10] { 1, 2, 3, 5, 6, 8, 9, 11, 14, 17 };
//            Array.Sort(numbers);
//            int minElement = numbers[0];
//            int maxElement = numbers[numbers.Length - 1];
//            var count = 1;


//            HashSet<int> numberSet = new HashSet<int>(numbers);
//            var missingNumbers = new List<int>();
//            for(int i = minElement; i <= maxElement; i++)
//            {
//                if (!numberSet.Contains(i))
//                {
//                    missingNumbers.Add(i);
//                }
//            }
//            foreach(int i in missingNumbers)
//            {
//                Console.WriteLine(i);
//            }

//        }

//    }
//}

//6.WAP to find the given string is Palindrome or not.
using System;
namespace logicals
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string to check Palindrome or Not : ");
            var str = Console.ReadLine();
            int left = 0;
            int right = str.Length - 1;
            bool isPalindrome = true;
            while (left < right)
            {
                if (str[left] != str[right])
                {
                    isPalindrome = false;
                    break;
                }
                left++;
                right--;
            }
            if (isPalindrome)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }
    }
}