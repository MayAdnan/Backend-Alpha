using Infrastructure.Models;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClientsController(IClientService clientService) : ControllerBase
{
    private readonly IClientService _clientService = clientService;


    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _clientService.GetClientsAsync();
        return Ok(result);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(string id)
    {
        var result = await _clientService.GetClientByIdAsync(id);
        return result == null ? NotFound() : Ok(result);
    }


    [HttpPost]
    public async Task<IActionResult> Create (AddClientFormData formData)
    {
        if (!ModelState.IsValid)
            return BadRequest(formData);

        var result = await _clientService.CreateClientAsync(formData);
        return result != null ? Ok(result) : BadRequest();
    }

    [HttpPut]
    public async Task<IActionResult> Update(EditClientFormData formData)
    {
        if (!ModelState.IsValid)
            return BadRequest(formData);

        var result = await _clientService.UpdateClientAsync(formData);
        return result != null ? Ok(result) : NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _clientService.DeleteClientAsync(id);
        return result ? Ok() : NotFound();
    }
}