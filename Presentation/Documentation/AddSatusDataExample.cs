using Infrastructure.Models;
using Swashbuckle.AspNetCore.Filters;

namespace Presentation.Documentation;

public class AddStatusDataExample : IExamplesProvider<AddStatusFormData>
{
    public AddStatusFormData GetExamples()
    {
        return new AddStatusFormData()
        {
            StatusName = "STARTED"
        };
    }
}