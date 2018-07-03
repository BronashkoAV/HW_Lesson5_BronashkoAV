using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            do
            {
                Console.Write("Введите логин: ");
                string str = Console.ReadLine();//Считывание строки
                Char[] simbols = str.ToArray();//Преобразование строки в массив символов

                if ((2 <= simbols.Length) && (simbols.Length <= 10) && (char.IsLetter(simbols[0])))//Проверка на то, что строка от 2 до 10 символов и первый символ - буква
                {
                    flag = true;
                }
                foreach (char x in simbols)//Пробегаем про массиву
                {
                    if (!char.IsLetterOrDigit(x)) //Проверяем, является ли каждый символ массива буквой или цифрой
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag) Console.WriteLine("Логин введет корректно!");
                else
                {
                    Console.WriteLine("Логин не корректен. Логин должен быть от 2 до 10 символов, содержащий только буквы или цифры, и при этом цифра не может быть первой");
                    flag = false;
                }
            } while (!flag);
            Console.Write("Bye!");
            Console.ReadKey();
        }
    }
}
