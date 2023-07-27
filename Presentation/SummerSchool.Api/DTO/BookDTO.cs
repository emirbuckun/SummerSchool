using SummerSchool.Entity.Entity;

namespace SummerSchool.Api.DTO
{
  public class BookDTO
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public BookDTO() { Title = string.Empty; }

    public BookDTO(Book book)
    {
      Id = book.Id;
      Title = book.Title;
    }
  }
}