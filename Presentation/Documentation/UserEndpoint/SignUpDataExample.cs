using Business.Dtos;
using Swashbuckle.AspNetCore.Filters;

namespace WebApi.Documentation.UserEndpoint;

public class SignUpDataExample : IExamplesProvider<SignUpForm>
{
    public SignUpForm GetExamples() => new()
    {
        FirstName = "Adam",
        LastName = "Doe",
        Email = "Adam.doe@domain.com",
        Password = "EatMe123!",
    };
}