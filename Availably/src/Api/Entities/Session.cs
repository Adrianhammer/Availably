namespace Availably.Api.Entities;

public class Session
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    //public ICollection<Participant> Participants { get; set; }
    //    = new List<Participant>();
}