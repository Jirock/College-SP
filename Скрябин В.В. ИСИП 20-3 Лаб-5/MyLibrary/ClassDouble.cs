using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace MyLibrary
{
    #region Ввод и вывод
    public static class ClassDouble
    {
        public static void DoubleInput()
        {
            Console.Clear();
            Console.WriteLine("Введите кол-во значений\nAlert! Минимум значений: 2 Максимум: 6\n");
            int count = int.Parse(Console.ReadLine());
            List<double> lst = new List<double>() { };

            //Проверка корректности ввода
            if (count < 2 || count > 6)
            {
                Console.WriteLine("Нужны значении не меньше 2 и не больше 6");
                Console.ReadLine();
                RepeatDoubleInput.Repeat();
            }

            //Добавление и ввод значений в список(типо массив)
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Введите {i + 1}-e число ");
                double a = double.Parse(Console.ReadLine());
                lst.Add(a);
            }
            //Вывод списка(типо массив)
            for (int i = 0; i < count; i++)
            {
                Console.Write(lst[i] + "\t");
            }

            //Преопределение 
            double res;
            switch (lst.Count)
            {
                case 2:
                    res = Cals.Plus(lst[0], lst[1]);
                    Console.WriteLine($"Результат: {res}");

                    using (var sw = new StreamWriter("MyFile\\NewFile.txt", true, Encoding.UTF8))
                    {
                        sw.WriteLine(res);
                    }

                    Console.ReadLine();
                    RepeatDoubleInput.Repeat();
                    break;

                case 3:
                    res = Cals.Plus(lst[0], lst[1], lst[2]);
                    Console.WriteLine($"Результат: {res}");

                    using (var sw = new StreamWriter("MyFile\\NewFile.txt", true, Encoding.UTF8))
                    {
                        sw.WriteLine(res);
                    }

                    Console.ReadLine();
                    RepeatDoubleInput.Repeat();
                    break;

                case 4:
                    res = Cals.Plus(lst[0], lst[1], lst[2], lst[3]);
                    Console.WriteLine($"Результат: {res}");
                    
                    using(var sw = new StreamWriter("MyFile\\NewFile.txt", true, Encoding.UTF8))
                    {
                        sw.WriteLine(res);
                    }

                    Console.ReadLine();
                    RepeatDoubleInput.Repeat();
                    break;

                case 5:
                    res = Cals.Plus(lst[0], lst[1], lst[2], lst[3], lst[4]);
                    Console.WriteLine($"Результат: {res}");

                    using (var sw = new StreamWriter("MyFiles\\NewFile.txt", true, Encoding.UTF8))
                    {
                        sw.WriteLine(res);
                    }
                    
                    Console.ReadLine();
                    RepeatDoubleInput.Repeat();
                    break;

                case 6:
                    res = Cals.Plus(lst[0], lst[1], lst[2], lst[3], lst[4], lst[5]);
                    Console.WriteLine($"Результат: {res}");

                    using (var sw = new StreamWriter("MyFile\\NewFile.txt", true, Encoding.UTF8))
                    {
                        sw.WriteLine(res);
                    }

                    Console.ReadLine();
                    RepeatDoubleInput.Repeat();
                    break;

                default:
                    DoubleInput();
                    RepeatDoubleInput.Repeat();
                    break;
            }
        }
    }
    #endregion

    #region Выход и вспомогательный код позволяющий продолжить ввод и вывод
    public static class RepeatDoubleInput
    {
        public static void Repeat()
        {
            Console.Clear();
            Console.WriteLine("Выберите: (1)Продолжить (2)Выход");
            sbyte Choose = sbyte.Parse(Console.ReadLine());
            //Проверка на корректность
            if(Choose > 2 || Choose < 1 )
            {
                Console.WriteLine("Вам дали только две команды, пройдите заново!");
                Console.ReadLine();
                Repeat();
            }

            switch (Choose)
            {   //Продолжить ввод и вывод
                case 1:
                    ClassDouble.DoubleInput();
                    break;
                //Выход
                case 2:
                    Console.WriteLine("Нажмите что нибудь чтобы выйти");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
            }
        }
    }
    #endregion

    #region Перегрузка методов
    public static class Cals
    {
        //Тут 2 числа
        public static double Plus(double a, double b)
        {
            return a + b;
        }
        //Тут 3 чисел
        public static double Plus(double a, double b, double c)
        {
            return a + b + c;
        }
        //Тут 4 чисел
        public static double Plus(double a, double b, double c, double d)
        {
            return a + b + c;
        }
        //Тут 5 чисел
        public static double Plus(double a, double b, double c, double d, double e)
        {
            return a + b + c + d;
        }
        // Тут 6 чисел
        public static double Plus(double a, double b, double c, double d, double e, double f)
        {
            return a + b + c + d + e + f;
        }
    }
    #endregion
}
