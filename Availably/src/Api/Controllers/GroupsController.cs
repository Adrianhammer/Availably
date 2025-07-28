using Availably.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Availably.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GroupsController : ControllerBase
{
    private readonly GroupService _service;

    public GroupsController(GroupService service)
    {
        _service = service;
    }
    
    // DTO for incoming create request
    public record CreateGroupDto(string Name);
    
    // DTO for response
    public record CreateGroupResult(Guid GroupId, string Name, DateTime CreatedAt);
    
    // POST /api/groups
    // Creates a new group and return its ID and creation time
    [HttpPost]
    public async Task<CreateGroupResult> Create([FromBody] CreateGroupDto dto)
    {
        var group = await _service.CreateGroupAsync(dto.Name);
        return new CreateGroupResult(group.Id, group.Name, group.CreatedAt);
    }
    
    // GET /api/groups/{id}
    // Retrieves group details (with members)
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var group = await _service.GetGroupAsync(id);
        return group is null 
            ? NotFound() 
            : Ok(group);
    }
}