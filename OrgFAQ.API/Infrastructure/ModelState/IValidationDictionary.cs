using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace OrgFAQ.API.Infrastructure.ModelState;

public interface IValidationDictionary
{
    void AddError(string key, string message);
    bool IsValid();
    void SetModelState(ModelStateDictionary modelState);
}
