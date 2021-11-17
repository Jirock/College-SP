using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//........Справочник
//........В начале консоль потребует от нас имя файла мы вводим и получаем нужные нам информации как по задании.
//........Михаил смотри и дополни работу чем то еще.
//........Файлы находятся в папке LAB-10/Files.
//........На данный момент я создал 4 файла расширения txt (1)Boomer (2)Fake (3)Goose (4)Zoomer
namespace LAB_10
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя файла(без расширения)");
            //Путь где есть файлы
            string Path = @"..\..\Files";
            //Вводим имя нужного файла
            string FileName = Console.ReadLine();

            foreach (string FindedFile in Directory.EnumerateFiles(Path, FileName + ".txt", SearchOption.AllDirectories))
            {
                //Экзепляр класса
                FileInfo FI = new FileInfo(FindedFile);
                //Выводим результат
                Console.WriteLine($"Имя файла: {FI.Name}\nРасширение файла: {FI.Extension}\nДата последнего доступа к файлу: {FI.LastAccessTime}");
            }

            Console.ReadLine();
        }
    }
}
