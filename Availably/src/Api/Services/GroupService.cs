using Availably.Api.Entities;
using Availably.Data;

namespace Availably.Api.Services;

public class GroupService
{
    // Contains application logic for creating and querying Groups.

    private readonly AvailablyDbContext _db;

    public GroupService(AvailablyDbContext db)
    {
        _db = db;
    }
    
    // Creates a new group with the specified name.
    public async Task<Group> CreateGroupAsync(string name)
    {
        var group = new Group
        {
            Id = Guid.NewGuid(),
            Name = name,
            CreatedAt = DateTime.UtcNow
        };

        _db.Groups.Add(group);
        await _db.SaveChangesAsync();
        return group;
    }

    // Retrieves a Group by its ID, including members of the group
    public async Task<Group?> GetGroupAsync(Guid groupId)
    {
        return _db.Groups
            .FirstOrDefault(g => g.Id == groupId);
    }
}