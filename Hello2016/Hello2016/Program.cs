using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello2016
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("{0 :F}", System.DateTime.Now);//输出当前时间
            foreach (string xx in args)
            {
                Console.WriteLine("Test {0}", xx);
            }
            MyHello myhl = new MyHello();
            myhl.MyHelloX();
            Console.ResetColor();
        }
    }
}
