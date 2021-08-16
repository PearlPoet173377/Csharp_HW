using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            
            WriteLine("Task 1:");
            string[] array = new string[4] { "Привет", ",", "мир", "!" };
            string t = "";
            foreach (var strings in array)
            {
                t += strings;
            }
            WriteLine(t + "\n");
            ReadKey();


            WriteLine("Task 2:");
            string str = "Широкая электрификация южных губерний даст мощный толчок подъёму сельского хозяйства";
            string[] array2 = str.Split(' ');
            Console.WriteLine($"Количество слов в фразе: {array2.Length}");
            foreach (var item in array2)
            {
                WriteLine(item);
            }
            ReadKey();


            WriteLine("Task 3:");
            int[] array3 = new int[] { 2, 5, 3, 9 };
            int result = (array3[0] * array3[1]) + (array3[2] * array3[3]);
            WriteLine($"Result: {result}\n");
            ReadKey();

            WriteLine("Task 4:");
            string[,] array4 = { { "Коля", "1000$" }, { "Вася", "500$" }, { "Петя", "200$" } };
            WriteLine($"Зарплата Коли: {array4[0, 1]}\n" + $"Зарплата Пети: {array4[2, 1]}");
            ReadKey();

            WriteLine("Task 5:");
            Random rand = new Random();
            int val = rand.Next(59);
            string message = "";
            if (val <= 15)
            {
                message = "в 1ую";
            }
            else if (val > 15 && val <= 30)
            {
                message = "во 2ую";

            }
            else if (val > 30 && val <= 45)
            {
                message = "в 3ую";
            }
            else if (val > 45 && val <= 60)
            {
                message = "в 4ую";
            }
            WriteLine($"Число {val} попадает {message} четверть часа");
            ReadKey();

            ////задание 6 не получилось

            WriteLine("Task 7:");
            int[] array7 = new int[] { 10, 20, 15, 17, 24, 35 };
            int array7_Sum = 0;
            foreach (var item in array7)
            {
                array7_Sum += item;
            }
            Console.WriteLine($"Сумма элементов массива; {array7_Sum}");
            ReadKey();

            WriteLine("Task 8:");
            Random rand8 = new Random();
            int[] array8 = new int[100];
            for (int i = 0; i < 100; i++)
            {
                array8[i] = rand8.Next(1, 100);
            }
            WriteLine("Вывод массива\n");
            int cEven = 0;
            int cOdd = 0;
            for (int i = 0; i < 100;)
            {
                for (int j = 0; j < 10; j++, i++)
                {
                    if (array8[i] % 2 == 0)
                    {
                        cEven++;
                    }
                    else
                    {
                        cOdd++;
                    }
                    Write(array8[i] + "\t");
                }
                WriteLine();
            }
            WriteLine($"Кол-во четных: {cEven}\n" + $"Кол-во нечетных: {cOdd}");
            ReadKey();

            WriteLine("Task 9:");
            string[,] array9 = { { "green", "зеленый" }, { "red", "красный" }, { "blue", "голубой" } };
            string[] en = new string[3];
            string[] ru = new string[3];
            for (int i = 0; i < 3; i++)
            {
                en[i] = array9[i, 0];
                ru[i] = array9[i, 1];
            }
            WriteLine("Массив en");
            foreach (var item in en)
            {
                WriteLine(item);
            }
            WriteLine("\nМассив ru");
            foreach (var item in ru)
            {
                WriteLine(item);
            }
            ReadKey();

            WriteLine("Task: 10");
            Random rand10 = new Random();
            int number1;
            int number2;
            do
            {
                number1 = rand10.Next(100, 10000);
            } while (number1 % 2 != 0);
            number2 = number1;
            int count10 = 0;
            for (; number1 >= 50; number1 /= 2)
            {
                count10++;
            }
            WriteLine($"Число {number2} нужно разделить {count10} раз, чтобы результат стал меньше 50");
            ReadKey();

            WriteLine("Task 11:");
            string string11 = "hello world";
            string11 = string11.ToUpper();
            WriteLine($"Строка в верхнем регистре: {string11}");
            ReadKey();

            WriteLine("Task 12:");
            string11 = string11.ToLower();
            WriteLine($"Строка в нижнем регистре: {string11}");
            ReadKey();

            WriteLine("Task 13:");
            string11 = string11.Replace('h', 'H');
            WriteLine($"Первый символ в верхнем регистре: {string11}");
            ReadKey();

            WriteLine("Task 14:");
            string string14 = "Привет Иван";
            WriteLine($"Строка до замены: {string14}");
            string14 = string14.Replace("Привет", "Пока");
            WriteLine($"Строка после замены: {string14}");
            ReadKey();

            ////задания 15 и 16 не совсем понял условие
        }
    }
}