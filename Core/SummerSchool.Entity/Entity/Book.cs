namespace SummerSchool.Entity.Entity
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime? PublishDate { get; set; }

        public Book()
        {
            Title = string.Empty;
            Author = string.Empty;
            Publisher = string.Empty;
            PublishDate = null;
        }

        public Book(int id, string title, string author, string publisher, DateTime? publishDate)
        {
            Id = id;
            Title = title;
            Author = author;
            Publisher = publisher;
            PublishDate = publishDate;
        }
    }
}
