using System.Net.Http.Json;

using Microsoft.AspNetCore.Components;

using ServerlessDays.WebApp.Models;

namespace ServerlessDays.WebApp.Components;

public partial class Agenda : ComponentBase
{
    /// <summary>
    /// Gets or sets the <see cref="HttpClient"/> instance injected by DI.
    /// </summary>
    [Inject]
    protected HttpClient? Http { get; set; }

    protected List<Speaker> SpeakerCollection { get; set; } = new List<Speaker>();

    /// <inheritdoc/>
    protected override async Task OnInitializedAsync()
    {
        this.SpeakerCollection = (await this.Http.GetFromJsonAsync<List<Speaker>>("data/speakers.json"))
                                 .OrderBy(p => p.SessionStart)
                                 .ToList();
    }
}
