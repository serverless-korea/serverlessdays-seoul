using System.Net.Http.Json;

using Microsoft.AspNetCore.Components;

using ServerlessDays.WebApp.Models;

namespace ServerlessDays.WebApp.Shared;

/// <summary>
/// This represents the partial entity of the navigation bar component.
/// </summary>
public partial class NavigationBar : ComponentBase
{
    /// <summary>
    /// Gets or sets the <see cref="HttpClient"/> instance injected by DI.
    /// </summary>
    [Inject]
    protected HttpClient? Http { get; set; }

    /// <summary>
    /// Gets or sets the navigation items.
    /// </summary>
    protected List<NavigationItem> NavigationItems { get; set; } = new List<NavigationItem>();

    /// <inheritdoc/>
    protected override async Task OnInitializedAsync()
    {
        this.NavigationItems = await this.Http.GetFromJsonAsync<List<NavigationItem>>("data/navigation.json");
    }

    /// <summary>
    /// Renders the target attribute for the navigation item.
    /// </summary>
    /// <param name="item"><see cref="NavigationItem"/> instance.</param>
    /// <returns>Returns the target attribute.</returns>
    protected Dictionary<string, object> RenderTarget(NavigationItem item)
    {
        var dict = new Dictionary<string, object>();
        if (item.IsExternal)
        {
            dict.Add("target", "_blank");
        }
        else if (item.Url.StartsWith("#"))
        {
            dict.Add("target", "_top");
        }

        return dict;
    }
}
