namespace OrgFAQ.API.Models
{
    public class Tag : EntityBase
    {
        public string Name { get; set; }

        public ICollection<QuestionTag> Questions { get; set; }
    }
}
