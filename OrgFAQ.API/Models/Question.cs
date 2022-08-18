namespace OrgFAQ.API.Models
{
    public class Question : EntityBase
    {
        public string UserId { get; set; }

        public string Title { get; set; }

        public string Context { get; set; }

        public DateTime CreateOn { get; set; }

        public ApplicationUser User { get; set; }

    }
}
