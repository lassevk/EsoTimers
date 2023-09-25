using Microsoft.AspNetCore.Components;

namespace EsoTimers.Components.Pages;

public partial class LandingPage
{
    [Inject]
    public NavigationManager NavigationManager { get; set; }
    
    protected override void OnInitialized()
    {
        try
        {
            string url = "/" + Guid.NewGuid().ToString();
            NavigationManager.NavigateTo(url);
        }
        catch (NavigationException)
        {
            
        }
    }
}