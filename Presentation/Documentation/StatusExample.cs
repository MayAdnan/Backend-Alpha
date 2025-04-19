using Infrastructure.Models;
using Swashbuckle.AspNetCore.Filters;

namespace Presentation.Documentation;

public class StatusExample : IExamplesProvider<Status>
{
    public Status GetExamples()
    {
        return new Status
        {
            Id = 1,
            StatusName = "STARTED"
        };
    }
}