using Infrastructure.Models;
using Swashbuckle.AspNetCore.Filters;

namespace Presentation.Documentation;

public class StatusAlreadyExistsExample : IExamplesProvider<ErrorMessage>
{
    public ErrorMessage GetExamples()
    {
        return new ErrorMessage
        {
            Message = "Status already exists"
        };
    }
}