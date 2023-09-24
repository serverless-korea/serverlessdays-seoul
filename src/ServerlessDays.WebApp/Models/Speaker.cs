namespace ServerlessDays.WebApp.Models;

public class Speaker : Person
{
    public string? SessionTitle { get; set; }
    public string? SessionDescription { get; set; }
    public DateTimeOffset? SessionStart { get; set; }
    public DateTimeOffset? SessionEnd { get; set; }
}