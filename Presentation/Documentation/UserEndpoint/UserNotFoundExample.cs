using Infrastructure.Models;
using Swashbuckle.AspNetCore.Filters;

namespace Presentation.Documentation.UserEndpoint;

public class UserNotFoundExample : IExamplesProvider<ErrorMessage>
{
    public ErrorMessage GetExamples() => new()
    {
        Message = "User with the given ID was not found."
    };
}

public class UserAlreadyExistsErrorExample : IExamplesProvider<ErrorMessage>
{
    public ErrorMessage GetExamples() => new()
    {
        Message = "User with the given 'email address' already exists."
    };
}