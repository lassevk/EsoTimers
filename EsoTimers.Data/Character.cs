using Microsoft.EntityFrameworkCore;

namespace EsoTimers.Data;

[Index("Id", "AccountId")]
public class Character
{
    public required int Id { get; set; }
    
    public required Guid AccountId { get; set; }
    
    public required string Name { get; set; }
}