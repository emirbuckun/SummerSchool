using SummerSchool.DataAccess.MsSql.DbContext;
using SummerSchool.DataAccess.Repository;
using SummerSchool.Entity.Entity;

namespace SummerSchool.DataAccess.MsSql.Repository
{
  public class GenreRepository : GenericRepository<Genre>, IGenreRepository
  {
    public GenreRepository(SummerSchoolDbContext _context) : base(_context) { }

    public Genre? GetByName(string name)
    {
      return GetAll()?.Where(x => x.Name == name).SingleOrDefault();
    }
  }
}