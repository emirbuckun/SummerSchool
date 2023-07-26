using SummerSchool.DataAccess.Repository;
using SummerSchool.Entity.Entity;

namespace SummerSchool.App.Handler
{
  public class GenreHandler
  {
    private readonly IGenreRepository _genreRepository;

    public GenreHandler(IGenreRepository genreRepository)
    {
      _genreRepository = genreRepository;
    }

    public List<Genre>? GetGenres()
    {
      return _genreRepository.GetAll();
    }

    public Genre? GetGenre(int id)
    {
      return _genreRepository.GetById(id);
    }

    public bool AddGenre(Genre book)
    {
      if (IsValid(book))
      {
        var existingGenre = _genreRepository.GetByName(book.Name);

        if (existingGenre == null)
        {
          _genreRepository.Add(book);
          return true;
        }
        return false;
      }
      return false;
    }

    public bool UpdateGenre(Genre book)
    {
      if (IsValid(book))
      {
        var existingGenre = _genreRepository.GetById(book.Id);

        if (existingGenre != null)
        {
          _genreRepository.Update(book);
          return true;
        }
        return false;
      }
      return false;
    }

    public bool DeleteGenre(int id)
    {
      var existingGenre = _genreRepository.GetById(id);

      if (existingGenre != null)
      {
        _genreRepository.Delete(id);
        return true;
      }
      return false;
    }

    private static bool IsValid(Genre book)
    {
      if (string.IsNullOrEmpty(book.Name))
        return false;
      return true;
    }
  }
}
