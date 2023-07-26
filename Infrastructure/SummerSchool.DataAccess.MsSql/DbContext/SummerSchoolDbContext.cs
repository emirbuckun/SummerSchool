using EF = Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SummerSchool.Entity.Entity;

namespace SummerSchool.DataAccess.MsSql.DbContext
{
    public class SummerSchoolDbContext : EF.DbContext
    {
        public DbSet<Book> Books { get; set; }
        public SummerSchoolDbContext(DbContextOptions options) : base(options) { }
    }
}
