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
            Console.WriteLine("Hello 2016 小伙伴们大家好！");
            foreach (string xx in args)
            {
                Console.WriteLine("Test {0}", xx);
            }
            Console.ResetColor();
        }
    }
}
