using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Lab_Library
{
    internal class CustomStackOverflowException:Exception
    {
        public string CustomMessage { get; }  // Дополнительное сообщение
        

        // Конструктор с параметрами
        public CustomStackOverflowException(string message)
            : base("Произошло переполнение стека: " + message)  // Передаем сообщение в базовый конструктор
        {
            CustomMessage = message;
            
        }

        // Переопределяем метод ToString для удобного вывода информации об ошибке
        public override string ToString()
        {
            return $"CustomStackOverflowException: {CustomMessage}";
        }

    }
}

