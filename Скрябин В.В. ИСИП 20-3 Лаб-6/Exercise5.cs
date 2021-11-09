using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LAB_6
{
    class Exercise5
    {
        public void Main()
        {
            using (StreamReader sr = new StreamReader("FileHouse\\FileExer2.txt", Encoding.GetEncoding(1251)))
            {
                string text = sr.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.ReadLine();
        }
    }
}
