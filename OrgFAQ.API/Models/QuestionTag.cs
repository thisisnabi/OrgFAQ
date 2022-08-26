namespace OrgFAQ.API.Models;

public class QuestionTag : EntityBase
{
    public int QuestionId { get; set; }
    public int TagId { get; set; }

    public Question Question { get; set; }
    public Tag Tag{ get; set; }

}
