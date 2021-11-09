using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LAB_6
{
    class Exercise2
    {
        public void Main()
        {
            Console.Clear();
            UserClass Text = new UserClass();
            Console.WriteLine("Введите имя");
            string Name = Console.ReadLine();
            Text.name = Name;

            Console.WriteLine("Введите возраст");
            sbyte Age = sbyte.Parse(Console.ReadLine());
            Text.age = Age;


            Console.WriteLine("Введите профессию");
            string Profession = Console.ReadLine();
            Text.profession = Profession;

            string a = Text.FileLord();
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }

    class UserClass
    {
        private string _name;
        private int _age;
        private string _profession;

        public string name
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 20)
                {
                    throw new ArgumentNullException(nameof(value));
                }
                this._name = value;
            }
            get { return _name; }
        }

        public int age
        {
            set
            {
                if (value > 70 || value < 18)
                {
                    throw new Exception("Возраст не должен быть выше чем 70 и ниже 18");
                }
                this._age = value;
            }
            get { return _age; }
        }

        public string profession
        {
            set
            {
                if (string.IsNullOrWhiteSpace(nameof(value)) || value.Length > 30)
                {
                    throw new ArgumentNullException(nameof(value));
                }
                this._profession = value;
            }
            get { return _profession; }
        }

        public string FileLord()
        {
            List<string> Mass = new List<string> { name, age.ToString(), profession };

            using (StreamWriter sw = new StreamWriter("FileHouse\\FileExer2.txt", true, Encoding.Default))
            {
                sw.WriteLine($"Имя: {Mass[0]} Возраст: {Mass[1]} Профессия: {Mass[2]}");
            }

            FileInfo file = new FileInfo("FileHouse\\FileExer2.txt");
            long FileMass = file.Length;

            var FileCount = 0;
            using (StreamReader sr = new StreamReader("FileHouse\\FileExer2.txt"))
            {
                var FileLines = File.ReadAllLines("FileHouse\\FileExer2.txt");
                FileCount = FileLines.Length;
            }

            return $"Размер файла {FileMass}, Кол-во сохраненных обьектов {FileCount}";
        }

    }
}
