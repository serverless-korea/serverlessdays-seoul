using Newtonsoft.Json;

namespace ServerlessDays.WebApp.Models;

public class SocialMedia
{
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public string? GitHub { get; set; }

    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public string? LinkedIn { get; set; }

    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public string? Facebook { get; set; }

    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public string? Instagram { get; set; }

    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public string? Twitter { get; set; }

    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public string? Website { get; set; }
}
