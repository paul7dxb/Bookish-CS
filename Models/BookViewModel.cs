using Bookish.Models.Database;

namespace Bookish.Models;

public class BookViewModel
{

    public class BookAuthorViewModel
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? PhotoUrl { get; set;}


        public BookAuthorViewModel(AuthorModel author)
        {
            Id = author.Id;
            Name = author.Name;
            PhotoUrl = author.PhotoUrl;
        }
    }

    public string? Isbn { get; }
    public string? Title { get; }
    public List<BookAuthorViewModel>? Authors { get; }
    public string? CoverPhotoUrl { get;  set;}
    public string? Blurb { get; set; }
    public string? Genre { get; set;}
    public int? YearPublished { get; set; }

    public int? Copies { get; set; }

    // public BookViewModel(string isbn, string title, string author){
    //     Isbn = isbn;
    //     Title = title;
    //     Authors = author;
    // }

    public BookViewModel(BookModel bookModel)
    {
        Isbn = bookModel.Isbn;
        Title = bookModel.Title;
        Authors = bookModel.Authors.Select(author => new BookAuthorViewModel(author)).ToList();
        CoverPhotoUrl = bookModel.CoverPhotoUrl;
        Blurb = bookModel.Blurb;
        Genre = bookModel.Genre;
        YearPublished = bookModel.YearPublished;
    }
    
    public BookViewModel(BookModel bookModel, int copies)
    {
        Isbn = bookModel.Isbn;
        Title = bookModel.Title;
        Authors = bookModel.Authors.Select(author => new BookAuthorViewModel(author)).ToList();
        CoverPhotoUrl = bookModel.CoverPhotoUrl;
        Blurb = bookModel.Blurb;
        Genre = bookModel.Genre;
        YearPublished = bookModel.YearPublished;
        Copies = copies;
    }
}
