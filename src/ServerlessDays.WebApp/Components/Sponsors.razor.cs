using System.Net.Http.Json;

using Microsoft.AspNetCore.Components;

using ServerlessDays.WebApp.Models;

namespace ServerlessDays.WebApp.Components;

public partial class Sponsors : ComponentBase
{
    /// <summary>
    /// Gets or sets the <see cref="HttpClient"/> instance injected by DI.
    /// </summary>
    [Inject]
    protected HttpClient? Http { get; set; }

    protected List<Sponsor> SponsorCollection { get; set; } = new List<Sponsor>();

    /// <inheritdoc/>
    protected override async Task OnInitializedAsync()
    {
        this.SponsorCollection = (await this.Http.GetFromJsonAsync<List<Sponsor>>("data/sponsors.json"))
                                 .OrderBy(p => p.Name)
                                 .ToList();
    }
}
