using Infrastructure.Models;
using Swashbuckle.AspNetCore.Filters;

namespace Presentation.Documentation.UserEndpoint;

public class UserValidationErrorExample : IExamplesProvider<ErrorMessage>
{
    public ErrorMessage GetExamples() => new()
    {
        Message = "Validation failed: Email is required."
    };
}