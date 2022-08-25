
namespace OrgFAQ.API.Models.IdentityModels;

public class ApplicationUser : IdentityUser<int>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public byte[] Avatar { get; set; }

    public ICollection<Question> Questions { get; set; }

}
