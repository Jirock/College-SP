using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Выберите задание\n--(1)Задание 1\n--(2)Задание 2\n--(3)Задание 3");
            byte Choose = byte.Parse(Console.ReadLine());
            if (Choose < 1 || Choose > 4 || Choose == null)
            {
                throw new ArgumentNullException(nameof(Choose));
            }

            switch (Choose)
            {
                case 1:
                    Exercise1 Trans = new Exercise1();
                    Trans.Main();
                    break;
                case 2:
                    Exercise2 Trans2 = new Exercise2();
                    Trans2.Main();
                    break;
                case 3:
                    Exercise5 Trans3 = new Exercise5();
                    Trans3.Main();
                    break;
            }
        }
    }
}
