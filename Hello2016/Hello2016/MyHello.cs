using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello2016
{
    public class MyHello
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("{0 :F}", System.DateTime.Now);//输出时间
            foreach (string xx in args)
            {
                Console.WriteLine("Test {0}", xx);
            }
            Console.ResetColor();
        }
    }
}
