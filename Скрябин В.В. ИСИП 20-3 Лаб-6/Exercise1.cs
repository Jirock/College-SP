using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LAB_6
{
    public class Exercise1
    {
        private int Num_1 = 0;
        private int Num_2 = 0;

        public void Main()
        {
            Console.Clear();
            Console.WriteLine("Введите кол-во чисел для первого числа");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите кол-во чисел для второго числа");
            int num2 = int.Parse(Console.ReadLine());

            this.Num_1 = num1;
            this.Num_2 = num2;

            Thread thread = new Thread(Number_1);
            thread.Start();

            Number_2();

            Console.ReadLine();
        }


        private void Number_1()
        {
            for (int i = 0; i < Num_1; i++)
            {
                Console.WriteLine("NUM1! ");
            }
        }

        private void Number_2()
        {
            for(int i = 0; i<Num_2; i++)
            {
                Console.WriteLine(new string(' ', 10) + "NUM2!");
            }
        }
    }
}
