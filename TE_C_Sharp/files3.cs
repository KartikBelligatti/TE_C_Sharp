using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_C_Sharp
{

    internal class files3
    {
        public static void Main()
        {
           // File.Move(@"E:\kartik\file1.txt", @"E:\kartik\belligatti\file1.txt");

            //File.Copy(@"E:\kartik\belligatti\file1.txt", @"E:\kartik\file1.txt");

            File.Delete(@"E:\kartik\belligatti\file1.txt");
        }
    }
}
