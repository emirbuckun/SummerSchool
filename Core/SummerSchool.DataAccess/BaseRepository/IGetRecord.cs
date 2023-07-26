using SummerSchool.Entity.Entity;

namespace SummerSchool.DataAccess.BaseRepository
{
    public interface IGetRecord<T> where T : BaseEntity
    {
        T? GetById(int id);
    }
}
