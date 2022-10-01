using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace TE_C_Sharp
{
    internal class RegularExpression
    {
        public static void Main()
        {
            mobile();

        }
        public static void mobile()
        {
            Console.WriteLine("mobile validation");
            string mobile = "987654321246564";
            var validate_mobile = Regex.IsMatch(mobile, @"^(0|\+91)?[789]\d{9}$");
            Console.WriteLine(validate_mobile);
            if (validate_mobile == true)
            {
                Console.WriteLine("Indian mobile number with 10 digit");
            }
            else
            {
                Console.WriteLine("Invalid Mobile number");
            }
        }
    }
}
