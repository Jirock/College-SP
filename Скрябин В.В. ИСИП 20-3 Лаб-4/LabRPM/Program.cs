using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LabRPM
{
    class Program
    {
        static void Main(string[] args)
        {
            Student();
        }

        static public void Student()
        {
            Console.Clear();
            Console.WriteLine("Выберите команду\n(1)Ввод нового студента\n(2)Посмотреть список студентов\n(3)Выход");
            sbyte Choose = sbyte.Parse(Console.ReadLine());

            switch (Choose)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Введите имя студента");
                    string name = Console.ReadLine();

                    Console.WriteLine("Введите фамилию студента");
                    string surname = Console.ReadLine();

                    Console.WriteLine("Введите отчество студента");
                    string patronymic = Console.ReadLine();

                    Console.WriteLine("Введите возраст студента");
                    int age = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите группу студента");
                    string group = Console.ReadLine();

                    CreatePerson a = new CreatePerson(name, surname, patronymic, age, group);
                    Console.WriteLine(a.ToString());
                    Console.ReadLine();
                    Student();
                    break;

                case 2:
                    using(var sr = new StreamReader("Student.txt"))
                    {
                        var text = sr.ReadToEnd();
                        Console.WriteLine(text);
                    }
                    Console.ReadLine();
                    Student();
                    break;

                default:
                    Console.WriteLine("Пустое значение или нету этой команды");
                    break;
            }
        }
    }
}
