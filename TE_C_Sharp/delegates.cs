using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TE_C_Sharp
{
    public delegate void BankName(string bankName, string interest);
    public class Bank
    {   
        public void CalculateInterest(string bankName, string interest)
        {
            Console.WriteLine($"Your Bank is :{bankName} and the rate of interest is {interest} ");
        } 
    }

    internal class delegates
    {
        public static void Main()
        {
            int n, t = 1;
            Bank bank = new Bank();
            BankName bn = bank.CalculateInterest;
            while (t != 0)
            {
                Console.WriteLine("-------------------------------------------------------------------------------------------");
                Console.WriteLine("Enter your option to know the interest rate: ");
                Console.WriteLine("1: SBI\t 2: HDFC Bank\t 3: Kotak Mahindra Bank\t 4: Axis Bank\t 5: ICICI Bank\t 6:Exit");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        bn("SBI", "2.70%");
                        break;
                    case 2:
                        bn("HDFC Bank", "3.00 % – 3.50 %");
                        break;
                    case 3:
                        bn("Kotak Mahindra Bank", "3.50%");
                        break;
                    case 4:
                        bn("Axis Bank", "3.00% – 3.50%");
                        break;
                    case 5:
                        bn("ICICI Bank", "3.00% – 3.50%");
                        break;
                    case 6:
                        t = 0;
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }      
}
