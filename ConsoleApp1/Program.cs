using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string accountCode = "AS0048";
            string accountCode = "1011A";
            if (!accountCode.StartsWith("A") && !accountCode.StartsWith("V"))
            {
                accountCode = "A" + accountCode;
            }
        }
    }
}
