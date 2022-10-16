using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Application_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client service1Client = new ServiceReference1.Service1Client();
            string choice = "";

            while (!choice.Equals("6"))
            {
                Console.WriteLine("\t\tWCF Assignment 1 ");
                Console.WriteLine("1. Prime Number");
                Console.WriteLine("2. Sum of digits");
                Console.WriteLine("3. Reverse a string");
                Console.WriteLine("4. Print HTML tags");
                Console.WriteLine("5. Sort 5 numbers");
                Console.WriteLine("6. Exit");
                Console.WriteLine("\tEnter your choice: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter a number to check prime number: ");
                        int num = int.Parse(Console.ReadLine());
                        string result = service1Client.primeNo(num);
                        Console.WriteLine(result);

                        break;

                    case "2":
                        Console.WriteLine("\nEnter any digits to do a sum of them: ");
                        num = int.Parse(Console.ReadLine());

                        int result2 = service1Client.sumOfDigit(num);
                        Console.WriteLine(result2);
                        break;

                    case "3":
                        Console.WriteLine("Enter a string: ");
                        Console.WriteLine(service1Client.reverseString(Console.ReadLine()));
                        break;

                    case "4":
                        Console.Write("Enter a tag: ");
                        string valueTag = Console.ReadLine();
                        Console.Write("Enter a data: ");
                        string htmlData = (Console.ReadLine());
                        Console.WriteLine(service1Client.htmlTags(valueTag, htmlData));
                        break;

                    case "5":
                        Console.Write("Enter a sorting type ascending or descending: ");
                        string sortingNum = Console.ReadLine();
                        Console.Write("Enter a list of integer: ");
                        string array = Console.ReadLine();
                        Console.WriteLine(service1Client.sortFiveNumbers(sortingNum, array));
                        break;

                    case "6":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("You selected some option please try again.");
                        break;
                }
            }
        }
    }
}
