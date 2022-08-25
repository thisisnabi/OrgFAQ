namespace OrgFAQ.API.Models;

public class Comment : EntityBase
{
    public string UserId { get; set; }
    public int QuestionId { get; set; }

    public string Context { get; set; }
    public DateTime CreateOn { get; set; }

    public ApplicationUser User{ get; set; }
    public Question Question { get; set; }

    public int ParretCommentId { get; set; }
    public Comment ParentComment { get; set; }

    public ICollection<Comment> ChildrenCommnet { get; set; }
}
