﻿using System;

namespace Generics 
{

  
  class Program
    {
       static void Main(string[] args)
        {

            var number = new Nullable<int>(5);
            Console.WriteLine("has Value ? " + number.HasValue );
            Console.WriteLine("Value: " + number.GetValueOrDefault());




            //var book = new Book { Isbn = "1111", Title = "C# Advanced" };


            ////var numbers = new List();
            ////numbers.Add(10);

            ////var books = new BookList();
            ////books.Add(book);

            //var numbers = new GenericList<int>();
            //numbers.Add(10);

            //var books = new GenericList<Book>();
            //books.Add(new Book());

            //var dictionary = new GenericDictionary<string, Book>();
            //dictionary.Add("1234", new Book());



            
        }
    }
}