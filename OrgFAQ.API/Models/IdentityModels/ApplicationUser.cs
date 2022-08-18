
namespace OrgFAQ.API.Models.IdentityModels;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public ICollection<Question> Questions { get; set; }

}
