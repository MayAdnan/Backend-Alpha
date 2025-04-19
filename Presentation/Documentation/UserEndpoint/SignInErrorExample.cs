using Infrastructure.Models;
using Swashbuckle.AspNetCore.Filters;

namespace Presentation.Documentation.UserEndpoint;

public class SignInErrorExample : IExamplesProvider<ErrorMessage>
{
    public ErrorMessage GetExamples() => new()
    {
        Message = "Invalid email or password."
    };
}