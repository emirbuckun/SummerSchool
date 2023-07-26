using SummerSchool.Entity.Entity;

namespace SummerSchool.DataAccess.BaseRepository
{
    public interface IGetAllRecord<T> where T : BaseEntity
    {
        List<T>? GetAll();
    }
}
