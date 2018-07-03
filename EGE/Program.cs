using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGE
{
    class Program
    {
        struct Students
        {
            public string SurName;
            public string Name;
            public int[] ratings;
            public float rating;
        }

        static void Main(string[] args)
        {
            int N;
            Console.Write("Введите количество учеников: ");
            do
            {
                Int32.TryParse(Console.ReadLine(), out N);
                if (!(N > 10 && N < 100)) Console.Write("Вы ввели не число или это число выходит за пределы. Введите число от 10 до 100: ");
            } while (N < 10 || N > 100);

            Students[] student = new Students[N];
            Console.WriteLine("Введите Фамилию, имя и оценки ученика в формате:\n<Фамилия> <Имя> <оценки>.\nНапример:\nИванов Петр 4 5 3");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Ученик {i + 1}: ");
                string[] s = Console.ReadLine().Split(' ');
                student[i].SurName = s[0];
                student[i].Name = s[1];
                student[i].ratings = new int[3];
                for (int j = 2; j <= 4; j++)
                {
                    student[i].ratings[j - 2] = int.Parse(s[j]);
                }
            }
            int k = 0;
            foreach (var x in student)
            {
                student[k].rating = ((float)(student[k].ratings[0] + student[k].ratings[1] + student[k].ratings[2]) / 3);
                k++;
            }
            Students temp = new Students();
            for (int i = 0; i < N; i++)
            {
                for (int j = i+1; j < N; j++)
                {
                    if (student[i].rating > student[j].rating)
                    {
                        temp = student[i];
                        student[i] = student[j];
                        student[j] = temp;
                    }
                }
            }
            int a = 0;
            int h = 0;
            do
            {
                if (h == student.Length) a = 3;
                Console.WriteLine($"Студент {h + 1}: Фамилия: {student[h].SurName}, Имя: {student[h].Name}, средний бал: {student[h].rating}");
                if (student[h].rating != student[h + 1].rating) a++;
                h++;
            } while (a < 3);
            Console.ReadKey();
        }
    }
}
