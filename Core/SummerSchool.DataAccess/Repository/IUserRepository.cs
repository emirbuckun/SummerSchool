using SummerSchool.DataAccess.BaseRepository;
using SummerSchool.Entity.Entity;

namespace SummerSchool.DataAccess.Repository
{
    internal interface IUserRepository : IGetRecord<Book>, IGetAllRecord<Book>, IAddRecord<Book>, IUpdateRecord<Book>, IDeleteRecord { }
}
