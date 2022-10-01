using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_C_Sharp
{
    internal class Class2
    {

       public enum num{
            A,
            B,
            C,
        }

        public static void bonus(int bonus,num l)
        {
            if ((int)l == 0)
            {
                Console.WriteLine(bonus);
            }
            else if ((int)l == 1)
            {

            }
        }
        public static void Main()
        {
            bonus(200, num.A);
        }
    }
}
