using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork2
{
    class HomeWork2
    {

        public static bool Authorization()
        {
            String Login = "root";
            String Password = "GeekBrains";
            Console.WriteLine("Для авторизации необходимо ввести Login и Password");
            Console.ReadLine();
            Console.WriteLine("Введите Login:");
            string userLogin = Console.ReadLine();

            Console.WriteLine("Введите Password:");
            string userPassword = Console.ReadLine();

            bool enter;

            if (Login == userLogin && Password == userPassword)
            {
                enter = true;

            }
            else
                enter = false;

            return enter;
        }

        public static void CountNumber()
        {
            Console.WriteLine("Введите любое число и мы посчитаем сколько в нем цифр!");
            string num = Console.ReadLine();
            int count = 0;

            for (int i = 0; i < num.Length; i++)
            {
                count++;
            }

            Console.WriteLine($"Колличество цифр в числе = {count}");
            Console.ReadLine();
        }

        public static void minNumber()
        {
            Console.WriteLine("Давайте найдем минимальное число из 3-х произвольных чисел");
            Console.WriteLine("Введите первое число");
            int one = int.Parse(Console.ReadLine());


            Console.WriteLine("Введите второе число");
            int two = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число");
            int three = int.Parse(Console.ReadLine());

            int min = 0;
            if (one < two && one < three)
                min = one;
            else if (two < three)
                min = two;
            else min = three;

            Console.WriteLine($"Минимальное число равно {min}");
            Console.ReadLine();
        }

        public static void SumNumbers()
        {
            int num = 1;
            int sum = 0;
            Console.WriteLine("Вводите любые целые числа. Когда надоест вводите - 0, а мы попрубуем посчитать сумму всех положительных четных чисел");
            while (num != 0)
            {
                Console.WriteLine("Введите число");
                num = int.Parse(Console.ReadLine());

                if (num > 0 && num % 2 == 0) sum += num;

            }
            Console.WriteLine($"Сумма всех четных положительных чисел = {sum}");
            Console.ReadLine();
        }

    }
}
