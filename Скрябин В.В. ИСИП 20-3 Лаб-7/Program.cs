using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Management;

namespace LAB_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Имя компьютера : {0}", Environment.MachineName);
            Console.WriteLine("Имя пользователя : {0}", Environment.UserName);
            Console.WriteLine("Путь : {0}", Environment.GetFolderPath(Environment.SpecialFolder.System));
            Console.WriteLine("Версия Windows: {0}", Environment.OSVersion);
            
            Console.WriteLine("\nМетрики: {0}, {1}, {2}", SystemMetric.SM_CXSCREEN, SystemMetric.SM_CXVSCROLL, SystemMetric.SM_CYHSCROLL);

            Console.WriteLine("\nСистемные параметры: ");
            Console.WriteLine("Число процессоров : {0}", Environment.ProcessorCount);
            Console.WriteLine("64 Bit операционная система? : {0}", Environment.Is64BitOperatingSystem ? "Да" : "Нет");
            Console.WriteLine("Логические диски : {0}", String.Join(", ", Environment.GetLogicalDrives()).TrimEnd(',', ' ').Replace("\\", String.Empty));
            Console.ReadLine();
        }
    }


    public enum SystemMetric
    {
        SM_CXSCREEN = 0,  // 0x00
        SM_CYSCREEN = 1,  // 0x01
        SM_CXVSCROLL = 2,  // 0x02
        SM_CYHSCROLL = 3,  // 0x03
        SM_REMOTECONTROL = 0x2001, // 0x2001
    }
}

