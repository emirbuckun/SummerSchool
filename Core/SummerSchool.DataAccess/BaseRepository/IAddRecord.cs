using SummerSchool.Entity.Entity;

namespace SummerSchool.DataAccess.BaseRepository
{
    public interface IAddRecord<T> where T : BaseEntity
    {
        T Add(T item);
    }
}
