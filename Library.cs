using System; // Подключение библиотеки для работы со стандартными классами C#

public class Library
{
    // Поля класса (автоматические свойства)
    public string Name { get; set; } // Название библиотеки
    public int BookFund { get; set; } // Количество книг в библиотечном фонде
    public int ReadingRoomSeats { get; set; } // Количество мест в читальном зале
    public double SubscriptionFee { get; set; } // Абонентская плата за посещение
    public bool HasDigitalLibrary { get; set; } // Наличие цифровой библиотеки (true - есть, false - нет)
    public int FoundedYear { get; set; } //Год основания библиотеки

    // Статическое поле для подсчета количества созданных объектов
    public static int ObjectCount { get; private set; } = 0;

    // Конструкторы

    // Конструктор без параметров, увеличивает счетчик созданных объектов
    public Library()
    {
        ObjectCount++;
    }

    // Конструктор с одним параметром (название)
    public Library(string name) : this()
    {
        Name = name; // Инициализируем название библиотеки
    }

    // Конструктор с двумя параметрами (название и фонд книг)
    public Library(string name, int bookFund) : this(name)
    {
        BookFund = bookFund; // Инициализируем количество книг в фонде
    }

    // Конструктор с шестью параметрами, заполняет все поля
    public Library(string name, int bookFund, int seats, double fee, bool digitalLibrary, int foundedYear) : this(name, bookFund)
    {
        ReadingRoomSeats = seats; // Устанавливаем количество мест в читальном зале
        SubscriptionFee = fee; // Устанавливаем абонентскую плату
        HasDigitalLibrary = digitalLibrary; // Устанавливаем наличие цифровой библиотеки
        FoundedYear = foundedYear; // Устанавливаем дату основания
    }

    // Переопределенный метод ToString(), возвращает строковое представление объекта
    public override string ToString()
    {
        return $"{Name}, {ReadingRoomSeats}, {FoundedYear}, " +
               $"{BookFund}, {SubscriptionFee}," +
               $"{((HasDigitalLibrary)?"Да":"Нет")}";
    }

    // Метод для получения значения конкретного поля по его названию
    public string GetField(string fieldName)
    {
        return fieldName switch
        {
            "Название" => $"Название: {Name}",
            "Фонд книг" => $"Фонд книг: {BookFund}",
            "Места" => $"Мест в зале: {ReadingRoomSeats}",
            "Абонентская плата" => $"Абонентская плата: {SubscriptionFee}",
            "Цифровая библиотека" => $"Цифровая библиотека: {HasDigitalLibrary}",
            "Год основания" => $"Год основания: {FoundedYear}",
            _ => "Некорректное поле"
        };
    }

    // Метод для вывода количества книг в шестнадцатеричном представлении
    public string GetHexBookFund()
    {
        return $"Фонд в 16-ричном формате: {BookFund:X}";
    }

    // Порождающий паттерн - Строитель (Builder);
    public class LibraryBuilder
    {
        private readonly Library _library;

        public LibraryBuilder()
        {
            _library = new Library(); // Создаем пустой объект
        }

        public LibraryBuilder SetName(string name)
        {
            _library.Name = name;
            return this;
        }

        public LibraryBuilder SetBookFund(int bookFund)
        {
            _library.BookFund = bookFund;
            return this;
        }

        public LibraryBuilder SetReadingRoomSeats(int seats)
        {
            _library.ReadingRoomSeats = seats;
            return this;
        }

        public LibraryBuilder SetSubscriptionFee(double fee)
        {
            _library.SubscriptionFee = fee;
            return this;
        }

        public LibraryBuilder SetDigitalLibrary(bool hasDigital)
        {
            _library.HasDigitalLibrary = hasDigital;
            return this;
        }

        public LibraryBuilder SetFoundedYear(int year)
        {
            _library.FoundedYear = year;
            return this;
        }

        public Library Build()
        {
            return _library; // Возвращаем готовый объект
        }
    }
}
