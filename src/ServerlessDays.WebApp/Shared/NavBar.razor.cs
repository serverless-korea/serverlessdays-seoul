using Microsoft.AspNetCore.Components;

namespace ServerlessDays.WebApp;

public partial class NavBar : ComponentBase
{
    [Inject]
    protected HttpClient? Http { get; set; }

    protected List<NavigationItem>? NavigationItems { get; set; }

    protected override async Task OnInitializedAsync()
    {

    }
}
