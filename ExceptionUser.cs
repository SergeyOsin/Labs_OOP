using System;

namespace _1_Lab_Library
{
    // Создаем кастомное исключение, наследуемое от Exception
    public class ExceptionUser : Exception
    {
        public string CustomMessage { get; set; }  // Дополнительное сообщение
        public DateTime ErrorTime { get; set; }    // Время возникновения ошибки

        // Конструктор с параметрами
        public ExceptionUser(string message)
            : base(message)  // Передаем сообщение в базовый конструктор
        {
            CustomMessage = message;
            ErrorTime = DateTime.Now; // Заполняем время ошибки
        }
        public override string ToString()
        {
            return $"CustomStackOverflowException: {CustomMessage} (Время: {ErrorTime})";
        }
    }
}
