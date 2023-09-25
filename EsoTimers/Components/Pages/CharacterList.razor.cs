using EsoTimers.Data;

using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace EsoTimers.Components.Pages;

public partial class CharacterList
{
    [Parameter]
    public Guid AuthId { get; set; }
    
    [Inject]
    public IDbContextFactory<EsoTimersDbContext>? DbContextFactory { get; set; }

    private List<Character>? _characters;

    protected override async Task OnInitializedAsync()
    {
        await RefreshCharacterList();
    }

    private async Task RefreshCharacterList()
    {
        if (DbContextFactory is null)
            return;
        
        await using EsoTimersDbContext dbContext = await DbContextFactory.CreateDbContextAsync();
        _characters = await dbContext.Characters
           .OrderBy(ch => ch.Name)
           .ToListAsync();
    }
}