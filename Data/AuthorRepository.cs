
using BookProject_Homework.Models;

namespace BookProject_Homework.Data;

public class AuthorRepository : IAuthorRepository
{
    private readonly List<Author>? _authors;
    public AuthorRepository()
    {
        _authors = new List<Author>
        {
            new Author{ID=1,Name="Nazım Hikmet"},
            new Author{ID=2,Name="Atilla İlhan"},
            new Author{ID=3,Name="Stefan Zweig"},
            new Author{ID=4,Name="Jose Saramago"},
            new Author{ID=5,Name="Gabriel Garcia Marquez"},
            new Author{ID=6,Name="Sait Faik Abasıyanık"}

        };
    }

    public void Add(Author author)
    {
        _authors.Add(author);
    }

    public void Delete(int ID)
    {
        Author author = _authors.SingleOrDefault(x => x.ID == ID);
        if (author is not null)
        {
            _authors.Remove(author);
        }
    }

    public List<Author> GetAll()
    {
        return _authors.ToList();

    }

    public Author GetByID(int ID)
    {
        Author? author = _authors.FirstOrDefault(x => x.ID == ID);
        if (author is not null)
        {
            return author;
        }
        return null;
    }
}
