using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace OrgFAQ.API.Infrastructure.ModelState;

public class ValidationDictionary : IValidationDictionary
{
    private ModelStateDictionary _modelState;
  
    public void AddError(string key, string message) => 
            _modelState.AddModelError(key, message);
    
    public bool IsValid() => _modelState.IsValid;

    public void SetModelState(ModelStateDictionary modelState) => 
        _modelState = modelState;
}
