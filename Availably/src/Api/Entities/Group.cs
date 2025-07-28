namespace Availably.Api.Entities;

// Represents a "group" for which members report availability
public class Group
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    //public ICollection<Participant> Participants { get; set; }
    //    = new List<Participant>();
}