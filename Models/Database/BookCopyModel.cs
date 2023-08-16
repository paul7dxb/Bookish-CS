using Microsoft.EntityFrameworkCore;
namespace Bookish.Models.Database;

[PrimaryKey("Barcode")]
public class BookCopyModel
{
    public string? Barcode { get; set; }
    public BookModel? Book { get; set; }

}
