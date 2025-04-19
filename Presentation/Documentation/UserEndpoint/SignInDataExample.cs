using Infrastructure.Models;
using Swashbuckle.AspNetCore.Filters;

namespace Presentation.Documentation.UserEndpoint;

public class SignInDataExample : IExamplesProvider<SignInFormData>
{
    public SignInFormData GetExamples() => new()
    {
        Email = "john.doe@domain.com",
        Password = "BytMig123!",
        RememberMe = false,
    };
}