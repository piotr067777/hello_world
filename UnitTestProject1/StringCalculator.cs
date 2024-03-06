using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public static class StringCalculator
    {
        public static int Calculate(string s)
        {
            if (s == "") return 0;

            return Int32.Parse(s);
        }
    }
}
