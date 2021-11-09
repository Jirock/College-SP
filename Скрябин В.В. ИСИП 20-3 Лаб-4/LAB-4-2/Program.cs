using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            People a = new People();
            People b = (People)a.Clone();

            b.Age = 19;
            b.Name = "Sanya";

            a.Dispose();

            Console.WriteLine("Имя: {0} Возраст: {1}", b.Name, b.Age);
            Console.ReadLine();
        }
    }

    class People : ICloneable, IDisposable
    {
        public string Name = "Viktor";
        public byte Age = 22;
        public Object Clone()
        {
            return this.MemberwiseClone();
        }
        
        public void Dispose()
        {
            Console.Beep();
            Console.WriteLine("Disposed");
        }
    }
}
