using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace wcf_assignment1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public string primeNo(int num)
        {
            Console.Write("Enter a prime number : ");
            int number = int.Parse(Console.ReadLine());
            bool IsPrime = true;
            for (int i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            if (IsPrime)
            {
                Console.Write("It is Prime.");
            }
            else
            {
                Console.Write("It's not Prime.");
            }
            Console.ReadKey();

            return IsPrime.ToString();
        }

        public string sumOfDigit(int num)
        {
            int x, y, sum = 0;
            x = 0;
            while (x > 0)
            {
                y = x % 10;
                sum = sum + y;
                x = x / 10;
            }
        
            return sum.ToString();
        }

        public string reverseString(string value)
        {
            string stringOutput = "";
            //foreach (char c in value)
            //{
            //    stringOutput = c + stringOutput;
            //}

            char[] reverseString = value.ToCharArray();
            Array.Reverse(reverseString);
            stringOutput = new string(reverseString);
            return stringOutput;
        }

        public string htmlTags(string valueTag, string htmlData)
        {
            return string.Format("<{0}>{1}</{0}>", valueTag, htmlData);
        }

        public string sortFiveNumbers(int[] num, string sortingNumbers)
        {
            string output = "";
            Array.Sort(num);
            if (sortingNumbers.Equals("Ascending"))
            {
                for (int i = 0; i < num.Length; i++)
                {
                    output += num[i].ToString() + ",";
                }
                output = output.Substring(0, output.Length - 1);
            }
            else if (sortingNumbers.Equals("Descending"))
            {
                for (int i = num.Length - 1; i >= 0; i--)
                {
                    output += num[i].ToString() + ",";
                }
                output = output.Substring(0, output.Length - 1);
            }
            else output = "Please enter a valid sorting number.";

            return output;
        }

    }
}
