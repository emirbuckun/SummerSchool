namespace SummerSchool.Entity.Entity
{
  public class Genre : BaseEntity
  {
    public string Name { get; set; }

    public Genre()
    {
      Name = string.Empty;
    }

    public Genre(int id, string name)
    {
      Id = id;
      Name = name;
    }
  }
}