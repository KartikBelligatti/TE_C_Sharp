using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internal;

namespace TE_C_Sharp
{
    internal class internalClass
    {
        internal void useOfInternal()
        {
            Console.WriteLine("This is internal access specifier");
        }
    }
    public class internalAccessModifiers
    {  
        public static void Main()
        {
            internalClass i = new internalClass();
            i.useOfInternal();

            accessing a = new accessing();
            a.display();
        }
    }
}
