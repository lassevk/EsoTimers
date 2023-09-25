using EsoTimers.Data;

using Microsoft.AspNetCore.Components;
                               
namespace EsoTimers.Components.SubComponents;

public partial class CharacterComponent
{
    [CascadingParameter]
    public Guid AuthId { get; set; }
    
    [Parameter]
    public int CharacterId { get; set; }

    private Character? _character;

    protected override async Task OnInitializedAsync()
    {
        _character = new Character { Id = 73, AccountId = AuthId, Name = "Jalla" };
        Console.WriteLine("HERE");
    }
}