using Infrastructure.Models;
using Swashbuckle.AspNetCore.Filters;

namespace Presentation.Documentation.UserEndpoint;

public class UpdateUserDataExample : IExamplesProvider<UpdateUserFormData>
{
    public UpdateUserFormData GetExamples() => new()
    {
        Id = "ae5f645a-9537-40c0-9016-2fffe881b1b3",
        Image= "u_ab3214b0-14b5-4f23-a8db-6466f465ce6d.png",
        FirstName = "John",
        LastName = "Doe",
        Email = "john.doe@domain.com",
        PhoneNumber = "+46 73-123 45 67",
        StreetName = "Nordkapsvägen 1",
        PostalCode = "136 57",
        City = "VEGA",
    };
}