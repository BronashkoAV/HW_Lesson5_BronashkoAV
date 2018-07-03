using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = scan(Console.ReadLine());
            string str2 = scan(Console.ReadLine());
            string scan(string str)
            {
                char[] word = str.ToArray();
                Array.Sort(word);
                return new string(word);
            }            
            Console.Write(str1.Equals(str2).ToString());
            Console.ReadKey();
        }
    }
}
