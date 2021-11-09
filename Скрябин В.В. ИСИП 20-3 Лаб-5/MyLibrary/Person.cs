using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyLibrary
{
    class Person
    {
        public static void InputPerson()
        {
            Console.Clear();
            Console.WriteLine("Выберите операцию\n (1)Зарегистрироваться (2)Пользователь (3)Назад");
            sbyte Choose = sbyte.Parse(Console.ReadLine());

            if (Choose < 1 || Choose > 3)
            {
                Console.WriteLine("Ошибка в вводе\n\nКликните чтобы продолжить");
                Console.ReadLine();
                InputPerson();
            }

            switch (Choose)
            {
                case 1:
                    Registr();
                    break;

                case 2:
                    AboutPerson();
                    break;

                case 3:
                    MainMenu.MenuBlock();
                    break;
            }
        }

        private static void Registr()
        {
            Console.Clear();
            Console.WriteLine("Вы попали в блок регистрации, макс. длина пароля 30\nВведите логин");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name) || name.Length < 2 || name.Length > 20)
            {
                Console.WriteLine("Ошибка в вводе имени попробуйте снова\n\nКликните чтобы продолжить");
                Console.ReadLine();
                InputPerson();
            }

            Console.WriteLine("Введите пароль");
            string password = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(password) || password.Length < 5 || password.Length > 30)
            {
                Console.WriteLine("Ошибка в вводе пароля\n\nКликните чтобы продолжить");
                Console.ReadLine();
                InputPerson();
            }

            else
            {
                using (var sw = new StreamWriter("MyFile\\PersonFile.txt"))
                {
                    sw.WriteLine(name + " " + password);
                }
                InputPerson();
            }
        }

        private static void AboutPerson()
        {
            string text;
            using (var sr = new StreamReader("myfile\\personfile.txt", Encoding.UTF8))
            {
                text = sr.ReadToEnd();
                Console.WriteLine(text);
                Console.ReadLine();
            }
        }

        //private static void LibraryMann()
        //{
        //    Console.Clear();
        //    Console.WriteLine("Введите логин");
        //    string name = Console.ReadLine();
        //    Console.WriteLine("Введите пароль");
        //    string password = Console.ReadLine();
        //    string user = name + " " + password;

        //    string text;
        //    using (var sr = new streamreader("myfile\\personfile.txt", encoding.utf8))
        //    {
        //        text = sr.readtoend();
        //    }
        //}


    }
}
