using OrgFAQ.API.Infrastructure.ModelState;

namespace OrgFAQ.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : OrgFAQController
    {
        public QuestionController(IValidationDictionary validationDictionary) : base(validationDictionary)
        {

        }



    }
}
