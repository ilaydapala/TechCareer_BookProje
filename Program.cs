

using BookProject_Homework.Business;
using BookProject_Homework.Data;
using BookProject_Homework.Models;

IBookService bookService = new BookService(new BookRepository());


Book book = new Book()
{
    ID = 8,
    Description = "Deneme",
    Price = 100,
    Stock = 400,
    Title = "Test"
};

Console.WriteLine("Kayıt ekleme : ");
bookService.Add(book);

//Console.WriteLine("Isbn ye göre getirme:");
//bookService.GetByIsnb("A");