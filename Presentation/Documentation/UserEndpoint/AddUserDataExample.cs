using Infrastructure.Models;
using Swashbuckle.AspNetCore.Filters;

namespace Presentation.Documentation.UserEndpoint;

public class AddUserDataExample : IExamplesProvider<AddUserFormData>
{
    public AddUserFormData GetExamples() => new()
    {
        FirstName = "John",
        LastName = "Doe",
        Email = "john.doe@domain.com",
    };
}