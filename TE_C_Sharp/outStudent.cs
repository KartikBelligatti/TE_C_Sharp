using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TE_C_Sharp
{
    internal class outStudent
    {
        public static void Main()
        {
            int sid;
            string sname,sdept;
            studentDetails(out sid,out sname, out sdept);
            Console.WriteLine("----------------------------");
            Console.WriteLine("Student Deatails are:");
            Console.WriteLine($"ID: {sid}");
            Console.WriteLine($"Name: {sname}");
            Console.WriteLine($"Department: {sdept}");
        }
        public static void studentDetails(out int sid, out  string sname, out string sdept)
        {
            Console.Write("Enter Student Id: ");
            sid = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            sname = Convert.ToString(Console.ReadLine());

            Console.Write("Enter Student Department: ");
            sdept= Convert.ToString(Console.ReadLine());
        }
    }
}
