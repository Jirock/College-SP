using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace MyLibrary
{
    public static class SomeType
    {
        public static void InputSomeText()
        {
            //Тут кароче вводите текст и направляете к методам те возвращают
            //значение полученное значение становиться мелким.
            Console.Clear();
            Console.WriteLine("Введите любой текст");
            var text = Console.ReadLine();
            var LowText = SomeText(text);
            Console.WriteLine($"{LowText.ToLower()}\nКликните чтобы выйти");
            Console.ReadLine();
            MainMenu.MenuBlock();
        }


        #region Перегрузка разных типов данных
        //Обычный текст
        private static string SomeText(string a)
        {
            return a;
        }
        //Символ
        private static char SomeText(char a)
        {
            return a;
        }
        //Число
        private static int SomeText(int a)
        {
            return a;
        }
        //Число с плавающей точкой
        private static double SomeText(double a)
        {
            return a;
        }
        #endregion
    }
}
