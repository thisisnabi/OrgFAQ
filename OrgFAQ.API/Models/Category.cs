namespace OrgFAQ.API.Models;

public class Category : EntityBase
{
    public string Name { get; set; }
    public ICollection<Question> Questions { get; set; }
}
