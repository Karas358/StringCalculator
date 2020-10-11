using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string reg = "//;\n1;3;5";
            StringAddition stringAddition = new StringAddition();
            int res = stringAddition.AddString(reg);
            Console.WriteLine(res.ToString());
            Console.ReadLine();
        }
    }
}
