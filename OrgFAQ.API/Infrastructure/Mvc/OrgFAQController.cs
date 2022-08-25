using OrgFAQ.API.Infrastructure.ModelState;

namespace OrgFAQ.API.Infrastructure.Mvc
{
    public abstract class OrgFAQController : ControllerBase
    {
        private readonly IValidationDictionary _validationDictionary;
        public OrgFAQController(IValidationDictionary validationDictionary)
        {
            _validationDictionary = validationDictionary;   
            _validationDictionary.SetModelState(ModelState);
        }
    }
}
