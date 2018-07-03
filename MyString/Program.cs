using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyString;

namespace MyString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            MyString ms = new MyString();
            ms.Longers(str);
            Console.ReadKey();
        }
    }
}
