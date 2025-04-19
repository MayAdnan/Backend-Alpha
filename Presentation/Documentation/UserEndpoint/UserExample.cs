using Infrastructure.Models;
using Swashbuckle.AspNetCore.Filters;

namespace Presentation.Documentation.UserEndpoint;

public class UserExample : IExamplesProvider<User>
{
    public User GetExamples() => new()
    {
        Id = "ae5f645a-9537-40c0-9016-2fffe881b1b3",
        FirstName = "John",
        LastName = "Doe",
        Email = "john.doe@domain.com",
        Role = "User",
        Image = null,
        Phone = "+46 73-123 45 67",
        Address = "Nordkapsvägen 1",
        PostalCode = "136 57",
        City = "VEGA",
    };
}