using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrgFAQ.API.Infrastructure.ModelState;

namespace OrgFAQ.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : APIController
    {
        public QuestionController(IValidationDictionary validationDictionary) : base(validationDictionary)
        {

        }

        
    }
}
