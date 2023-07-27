using SummerSchool.DataAccess.Repository;
using SummerSchool.Entity.Entity;

namespace SummerSchool.App.Handler
{
    public class BookHandler
    {
        private readonly IBookRepository _bookRepository;

        public BookHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public List<Book>? GetBooks()
        {
            return _bookRepository.GetAll();
        }

        public Book? GetBook(int id)
        {
            return _bookRepository.GetById(id);
        }

        public bool AddBook(Book book)
        {
            if (IsValid(book))
            {
                var existingBook = _bookRepository.GetByTitle(book.Title);

                if (existingBook == null)
                {
                    _bookRepository.Add(book);
                    return true;
                }
                return false;
            }
            return false;
        }

        public bool UpdateBook(Book book)
        {
            if (IsValid(book))
            {
                var existingBook = _bookRepository.GetById(book.Id);

                if (existingBook != null)
                {
                    _bookRepository.Update(book);
                    return true;
                }
                return false;
            }
            return false;
        }

        public bool DeleteBook(int id)
        {
            var existingBook = _bookRepository.GetById(id);

            if (existingBook != null)
            {
                _bookRepository.Delete(id);
                return true;
            }
            return false;
        }

        private static bool IsValid(Book book)
        {
            if (string.IsNullOrEmpty(book.Title))
                return false;
            return true;
        }
    }
}
