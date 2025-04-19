using Infrastructure.Models;
using Swashbuckle.AspNetCore.Filters;

namespace Presentation.Documentation.UserEndpoint;

public class SignUpDataExample : IExamplesProvider<SignUpFormData>
{
    public SignUpFormData GetExamples() => new()
    {
        FirstName = "Adam",
        LastName = "Doe",
        Email = "Adam.doe@domain.com",
        Password = "EatMe123!",
    };
}