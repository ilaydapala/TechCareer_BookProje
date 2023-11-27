﻿

using BookProject_Homework.Exeptions;
using BookProject_Homework.Models;

namespace BookProject_Homework.Data;

public class BookRepository : IBookRepository
{
    private readonly List<Book> _bookData;

    public BookRepository()
    {
        _bookData = new List<Book>()
        {
            new Book() {ID=1,CategoryID=1,AuthorID=1,Isbn="A",Description="Şiir",Price=250,Stock=1000,Title="Yaşamak Güzel Şey Be Kardeşim"},
            new Book() {ID=2,CategoryID=1,AuthorID=2,Isbn="A",Description="Şiir",Price=300,Stock=750,Title="Ben Sana Mecburum"},
            new Book() {ID=3,CategoryID=2,AuthorID=3,Isbn="B",Description="Roman",Price=240,Stock=550,Title="Olağan Üstü Bir Gece"},
            new Book() {ID=4,CategoryID=2,AuthorID=3,Isbn="B",Description="Roman",Price=400,Stock=1500,Title="Satranç"},
            new Book() {ID=5,CategoryID=3,AuthorID=4,Isbn="C",Description="Psikoloji",Price=800,Stock=400,Title="Körlük"},
            new Book() {ID=6,CategoryID=4,AuthorID=5,Isbn="D",Description="Büyülü Gerçekçilik",Price=1200,Stock=1700,Title="Yüzyıllık Yalnızlık"},
            new Book() {ID=7,CategoryID=5,AuthorID=6,Isbn="D",Description="Psikoloji",Price=600,Stock=800,Title="Son Kuşlar"}

        };
    }
    public void Add(Book book)
    {
        _bookData.Add(book);
    }

    public void Delete(int ID)
    {
        Book? book = _bookData.Where(x=>x.ID==ID).SingleOrDefault();
        if (book is null)
        {
            throw new BookNotFoundException(ID);
        }
        _bookData.Remove(book); 
    }

    public List<Book> GetAll()
    {
        return _bookData;
    }

    public Book GetByID(int ID)
    {
        Book? book = _bookData.SingleOrDefault(x=>x.ID==ID);
        if (book is null)
        {
            throw new BookNotFoundException(ID);
        }
        return book;
    }

    public Book GetByIsnb(string isnb)
    {
        Book? book = _bookData.FirstOrDefault(i => i.Isbn == isnb);
        if (book is null)
        {
            throw new BookNotFoundWithIsbn(isnb);
        }
        return book;
    }
}
