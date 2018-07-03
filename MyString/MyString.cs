using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyString
{
    class MyString
    {
        public void Pirnt(string str, int n)
        {
            char[] word = str.ToArray();
            string temp = "";
            List<string> tempList = new List<string>();
            foreach (char x in word)
            {
                if (char.IsLetter(x)) temp += x;
                else
                {
                    if (temp.Length <= n && temp != "")
                    {
                        tempList.Add(temp);
                    }
                    temp = "";
                }
            }
            foreach (var v in tempList)
            {
                Console.WriteLine(v);
            }
        }
        public void Remove(string str, char simbol)
        {
            Console.WriteLine(Regex.Replace(str, $@"\s*\w*{simbol}\b", "").Trim());
        }
        public void Longer(string str)
        {
            char[] word = str.ToArray();
            string temp = "";
            string max = "";
            foreach (char x in word)
            {
                if (char.IsLetter(x)) temp += x;
                else
                {
                    if (max.Length < temp.Length) max = temp;
                    temp = "";
                }
            }
            Console.WriteLine(max);
        }
        public void Longers(string str)
        {
            char[] word = str.ToArray();
            string temp = "";
            string max = "";
            List<string> allMax = new List<string>();
            foreach (char x in word)
            {
                if (char.IsLetter(x)) temp += x;
                else
                {
                    if (max.Length < temp.Length) max = temp;
                    temp = "";
                }
            }
            foreach (char x in word)
            {
                if (char.IsLetter(x)) temp += x;
                else
                {
                    if (max.Length == temp.Length) allMax.Add(temp);
                    temp = "";
                }
            }
            foreach (var v in allMax) Console.WriteLine(v);
        }
    }
}
