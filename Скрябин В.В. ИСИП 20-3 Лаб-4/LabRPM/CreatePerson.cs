using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LabRPM
{
    class CreatePerson
    {
        private string Name;
        private string Surname;
        private string Patronymic;
        private int Age;
        private string Group;


        public CreatePerson(string name, string surname, string patronymic, int age, string group)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length > 20 || name.Length < 2)
            {
                throw new MyNewException();
            }
            if (string.IsNullOrWhiteSpace(surname) || surname.Length > 25 || surname.Length < 5)
            {
                throw new MyNewException();
            }
            if (string.IsNullOrWhiteSpace(patronymic) || patronymic.Length > 30 || patronymic.Length < 5)
            {
                throw new MyNewException();
            }
            if (age > 27 || age < 16)
            {
                throw new MyAgeException();
            }
            if (group.Length > 15 || string.IsNullOrWhiteSpace(group))
            {
                throw new MyNewException();
            }

            this.Name = name;
            this.Surname = surname;
            this.Patronymic = patronymic;
            this.Age = age;
            this.Group = group;

            using (var sw = new StreamWriter("Student.txt", true, Encoding.UTF8))
            {
                sw.WriteLine("Имя студента: " + Name + "| Фамилия студента: " + Surname + "| Отчество студента: " + Patronymic + "| Возраст студента: " + Age + "| Группа студента: " + Group);
            }
        }

        public override string ToString()
        {
            return $"Имя студента: {Name}\n" +
                $"Фамилия студента: {Surname}\n" +
                $"Отчество студента: {Patronymic}\n" +
                $"Возраст студента: {Age}\n" +
                $"Группа студента: {Group}";
        }
    }
}
