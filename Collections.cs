using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Lab_Library
{
    internal class Collections
    {
        private Dictionary<string, Library> libraries; 

        // Делегат - «указатель на метод». говорит, какие методы могут быть связаны с ним. (как именно они должны выглядить)
        public delegate void CollectionChangedEventHandler(object sender, string message);
        // События - механизм, который позволяет объекту сообщать другим объектам о том, что что-то произошло.
        // Оно может хранить ссылки на методы, которые соответствуют этому делегату (имеют object sender, string message).
        public event CollectionChangedEventHandler LibraryAdded;
        public event CollectionChangedEventHandler LibraryRemoved;
        public event CollectionChangedEventHandler LibraryUpdated;
        public event CollectionChangedEventHandler CollectionCleared;

        // инициализация пустого экземпляра libraries типа Dictionary
        public Collections()
        {
            libraries = new Dictionary<string, Library>(); // Создаётся новый пустой словарь (Dictionary), который будет хранить
                                                           // объекты Library по ключу-строке (string).
        }
        
        public void AddLibrary(Library library)
        {
            if (library == null)
                throw new ArgumentNullException(nameof(library));

            if (libraries.ContainsKey(library.Name))
                throw new InvalidOperationException("Библиотека с таким именем уже существует.");

            libraries[library.Name] = library;

            // ? - безопасный вызов (есть подписчик)
            // . (точка – доступ к членам объекта)
            // Invoke выполняет вызов всех подписанных методов (у меня анонимная лямбда-функция.)
            LibraryAdded?.Invoke(this, $"Добавлена библиотека: {library.Name}");
        }
       
        public void RemoveLibrary(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Имя библиотеки не может быть пустым.");

            if (!libraries.ContainsKey(name))
                throw new KeyNotFoundException("Библиотека с таким именем не найдена.");

            libraries.Remove(name);

            LibraryRemoved?.Invoke(this, $"Удалена библиотека: {name}");
        }
        
        public Library GetLibrary(string name)
        {
           
            return libraries[name];
        }
       
        public void UpdateLibrary(string name, Library updatedLibrary)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Имя библиотеки не может быть пустым.");

            if (updatedLibrary == null)
                throw new ArgumentNullException(nameof(updatedLibrary));

            

            libraries[name] = updatedLibrary;

            
            LibraryUpdated?.Invoke(this, $"Обновлена библиотека: {name}");
        }
        
        public void Clear()
        {
            libraries.Clear();

            // Вызываем событие, сообщая, что коллекция очищена
            CollectionCleared?.Invoke(this, "Все библиотеки удалены из коллекции.");
        }
        
        public int Count
        {
            get { return libraries.Count; }
        }
    }
}
