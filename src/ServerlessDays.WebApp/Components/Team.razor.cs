using System.Net.Http.Json;

using Microsoft.AspNetCore.Components;

using ServerlessDays.WebApp.Models;

namespace ServerlessDays.WebApp.Components;

public partial class Team : ComponentBase
{
    /// <summary>
    /// Gets or sets the <see cref="HttpClient"/> instance injected by DI.
    /// </summary>
    [Inject]
    protected HttpClient? Http { get; set; }

    protected List<TeamMember> TeamMemberCollection { get; set; } = new List<TeamMember>();

    /// <inheritdoc/>
    protected override async Task OnInitializedAsync()
    {
        this.TeamMemberCollection = (await this.Http.GetFromJsonAsync<List<TeamMember>>("data/team.json"))
                                    .OrderBy(p => p.Name)
                                    .ToList();
    }
}
