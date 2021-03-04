using System;
using System.Collections.Generic;

namespace HomeWork2   //Лукьянов Владимир Сергеевич. Домашнее задание по Уроку №2
{
    class Program
    {
        static int sum = 0;
        static void Main(string[] args)
        {
            //HomeWork2.minNumber(); // 1. Метод который возвращает минимальное из 3-х чисел

            //HomeWork2.CountNumber(); // 2. метод подсчета количества цифр числа

            //HomeWork2.SumNumbers(); // 3. Подсчитать сумму всех нечетных положительных чисел.

            #region 4. Проверка Login и Password
            //int count = 2;
            //do
            //{
            //    bool a = HomeWork2.Authorization();
            //    if (a == true)
            //    {
            //        Console.WriteLine("Поздравляю! Вы успешно Авторизировались! ");
            //        return;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Неверное имя пользователя или пароль! У вас осталось {count} попыток ");
            //    }
            //    count--;
            //} while (count != -1);

            //Console.ReadLine();
            #endregion

            #region 5. Index Массы тела

            //Console.WriteLine("Добро пожаловать в институт по изучению ожирения!");
            //Console.WriteLine("Для того что бы наши советы были корректны, ответьте пожалуйста на несколько вопросов:");
            //Console.ReadLine();

            //Console.WriteLine("Укажите ваш рост в сантиметрах:");
            //Double h = double.Parse(Console.ReadLine())/100;
            //Console.WriteLine("Укажите ваш вес в кг:");
            //Double m = double.Parse(Console.ReadLine());

            //double indexM = m / (h * h);
            //double mUP = (23 * h * h) - m;
            //double mDown = m - (23 * h * h);

            //indexM = Math.Round(indexM, 2);
            //mUP = Math.Round(mUP, 2);
            //mDown = Math.Round(mDown, 2);

            //if (indexM < 16) Console.WriteLine($"Ваш индекс массы тела = {indexM}. У вас выраженный дефицит массы тела, вам нужно набрать {mUP} кг."); 
            //if (indexM >= 16 && indexM <= 18.5) Console.WriteLine($"Ваш индекс массы тела = {indexM}. У вас недостаточная (дефицит) масса тела, вам нужно набрать {mUP} кг."); 
            //if (indexM > 18.5 && indexM <= 25) Console.WriteLine($"Ваш индекс массы тела = {indexM}. Ваш вес в норме!.");
            //if (indexM > 25 && indexM <= 30) Console.WriteLine($"Ваш индекс массы тела = {indexM}. У вас Избыточная масса тела (предожирение), вам нужно похудеть на {mDown} кг.");
            //if (indexM > 30 && indexM <= 35) Console.WriteLine($"Ваш индекс массы тела = {indexM}. У вас ожирение, вам нужно похудеть на {mDown} кг.");
            //if (indexM > 35 && indexM <= 40) Console.WriteLine($"Ваш индекс массы тела = {indexM}. У вас резкое ожирение, вам нужно похудеть на {mDown} кг.");
            //if (indexM > 40) Console.WriteLine($"Ваш индекс массы тела = {indexM} У вас ОЧЕНЬ резкое ожирение, вам нужно похудеть на {mDown} кг.");
            //Console.ReadKey();
            #endregion

            #region 6*. Хорошие числа

            //long time = DateTime.Now.Ticks;

            //int count = 0;
            //int s = 0;
            //int b = 0;
            //int j = 0;
            //var niceNumber = new List<int>();
            //for (int i = 1; i < 1000000000; i++)
            //{
            //    j = i; 
            //    while (j > 0)
            //    {
            //        s = s + j % 10;
            //        j = j / 10;
            //    }
            //    if (i % s == 0) 
            //    {
            //        count++;
            //        niceNumber.Add(i);
            //    } 
            //    else count = count + 0;
            //    s = 0;

            //}
            //Console.WriteLine($"Колличество Хороших чисел = {count}");
            //Console.ReadKey();

            //time = DateTime.Now.Ticks - time;
            //Console.WriteLine($"Время выполнение программы = {time}");
            //Console.ReadKey();

            //Console.WriteLine("Давайте взглянем на эти числа! ");
            //Console.ReadKey();

            //foreach (int num in niceNumber)
            //Console.WriteLine(num);
            //Console.ReadKey();


            #endregion

            #region 7*. Рекурсивный метод


            //Console.WriteLine("Введите первое число");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите второе число");
            //int b = int.Parse(Console.ReadLine());

            //int sumNumber = Rec(a, b);

            //static int Rec (int x, int y)
            //{
                
            //    if (x < y-1)
            //    {
            //        x = x + 1;
            //        Console.WriteLine($"{x}");
            //        sum = sum + x;
            //        Rec(x, y);
            //    }
                

            //    return sum;  
            //}

            //Console.WriteLine($"Сумма чисел заданного диапазона = {sumNumber}");
            //Console.ReadLine();




            #endregion

        }


    }
}


        
    

