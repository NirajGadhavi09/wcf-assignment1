using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Services.Description;

namespace wcf_assignment1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public string primeNo(int num)
        {

            int i;
            int flag = num / 2;

            for (i = 2; i <= flag; i++)
            {
                if (num % i == 0)
                {
                    break;
                }
            }
            if (i > flag)
            {
                return "It's a is Prime Number";
            }
            else
            {
                return "It's a not Prime Number";
            }
        }

        public int sumOfDigit(int x)
        {
            int sum = 0, y;

            while (x > 0)
            {
                y = x % 10;
                sum = sum + y;
                x = x / 10;
            }
            return sum;
        }

        public string reverseString(string value)
        {
            string stringOutput = "";
            char[] reverseString = value.ToCharArray();
            Array.Reverse(reverseString);
            stringOutput = new string(reverseString);
            return stringOutput;
        }

        public string htmlTags(string valueTag, string htmlData)
        {
            return string.Format("<{0}>{1}</{0}>", valueTag, htmlData);
        }

        public string sortFiveNumbers(string sortAscDesc, string sortingNumbers)
        {

            int[] array = Array.ConvertAll(sortingNumbers.Split(','), x => int.Parse(x));
            Array.Sort(array);
            if (sortAscDesc == "Ascending" || sortAscDesc == "ascending")
            {
                return string.Join(",", array);
            }
            else if (sortAscDesc == "Descending" || sortAscDesc == "descending")
            {
                Array.Reverse(array);
                return string.Join(",", array);
            }
            return "Please enter a valid input for sorting.";

        }

        
    }
}
