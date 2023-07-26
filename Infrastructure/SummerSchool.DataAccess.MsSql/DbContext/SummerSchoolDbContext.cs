using ef = Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SummerSchool.Entity.Entity;

namespace SummerSchool.DataAccess.MsSql.DbContext
{
    public class SummerSchoolDbContext : ef.DbContext
    {
        public DbSet<Book> Books { get; set; }
        public SummerSchoolDbContext(DbContextOptions options) : base(options) { }
    }
}
