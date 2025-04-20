using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StatusController(IStatusService statusService) : ControllerBase
{
    private readonly IStatusService _statusService = statusService;

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _statusService.GetStatusesAsync();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var result = await _statusService.GetStatusByIdAsync(id);
        return result == null ? NotFound() : Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create(string statusName)
    {
        if (string.IsNullOrEmpty(statusName))
            return BadRequest("Status name cannot be null or empty.");
        var result = await _statusService.GetStatusByStatusNameAsync(statusName);
        return result != null ? Ok(result) : BadRequest();
    }

    [HttpPut]
    public async Task<IActionResult> Update(int id, string statusName)
    {
        if (string.IsNullOrEmpty(statusName))
            return BadRequest("Status name cannot be null or empty.");
        var result = await _statusService.GetStatusByIdAsync(id);
        return result != null ? Ok(result) : NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _statusService.GetStatusByIdAsync(id);
        return result != null ? Ok(result) : NotFound();
    }
}