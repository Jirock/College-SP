using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRPM
{
    class MyNewException : Exception
    {
        public MyNewException() : base("Ошибка при заполнении, рекомендуется все начать заново")
        {
        }

        public MyNewException(string message) : base(message)
        {
        }
    }

    class MyAgeException : Exception
    {
        public MyAgeException() : base("Вы ввели неподходящий возраст(слишком старый или юный)")
        {
        }

        public MyAgeException(string message) : base(message)
        {
        }
    }
}
