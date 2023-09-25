using Microsoft.AspNetCore.Components;

namespace EsoTimers.Components.Layout;

public partial class MainLayout
{
    [Inject]
    public NavigationManager NavigationManager { get; set; }

    protected override Task OnAfterRenderAsync(bool firstRender)
    {
        // var url = "/" + Guid.NewGuid();
        var url = "/78a41596-b436-4af5-9b0c-444e318b8b11";
        NavigationManager.NavigateTo(url);
        return Task.CompletedTask;
    }
}