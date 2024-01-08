using System;

namespace Generics
{
    //public class Book
    //{
    //    // properties and methods specific to the Book class here
    //}

    public class BookList
    {
        public void Add(Book book)
        {
            // Implementation for adding a book to the list
            throw new NotImplementedException();
        }

        public Book this[int index]
        {
            get
            {
                // Implementation for accessing a book by index
                throw new NotImplementedException();
            }
        }
    }

    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {
            // Implementation for adding a key-value pair to the dictionary
        }
    }

    public class GenericList<T>
    {
        public void Add(T value)
        {
            // Implementation for adding an object to the list
            throw new NotImplementedException();
        }

        public T this[int index]
        {
            get
            {
                // Implementation for accessing an object by index
                throw new NotImplementedException();
            }
        }
    }
}
