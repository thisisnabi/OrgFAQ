using OrgFAQ.API.Infrastructure.ModelState;

namespace OrgFAQ.API.Infrastructure.Mvc
{
    public class APIController : ControllerBase
    {
        private readonly IValidationDictionary _validationDictionary;
        public APIController(IValidationDictionary validationDictionary)
        {
            _validationDictionary = validationDictionary;   
            _validationDictionary.SetModelState(ModelState);
        }
    }
}
