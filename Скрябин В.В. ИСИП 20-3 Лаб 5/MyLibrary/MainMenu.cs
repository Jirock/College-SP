using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace MyLibrary
{
    public static class MainMenu
    {
        public static void MenuBlock()
        {
            bool a = false;
            while (a != true)
            {
                Console.Clear();
                Console.WriteLine("Выберите команду:\n(1)Первое задание\n(2)Второе задание\n(3)Третье задание\n(4)Четвертое задание\n(5)Выход");
                sbyte Choose = sbyte.Parse(Console.ReadLine());

                if(Choose < 1 || Choose > 5)
                {
                    Console.WriteLine("Вы ввели не существующую команду\n\nКликните чтобы продолжить...");
                    Console.ReadLine();
                    MenuBlock();
                }

                switch (Choose)
                {
                    case 1:
                        ClassDouble.DoubleInput();
                        break;

                    case 2:
                        SomeType.InputSomeText();
                        break;

                    case 3:
                        Person.InputPerson();
                        break;

                    case 4:
                        Console.WriteLine("Введите любой текст");
                        SomeType.InputSomeText();
                        break;
                    
                    case 5:
                        Environment.Exit(0);
                        break;
                }
                
            }

            Console.ReadLine();
        }   
    }
}
