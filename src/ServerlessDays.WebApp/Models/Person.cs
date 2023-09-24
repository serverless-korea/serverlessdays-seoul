namespace ServerlessDays.WebApp.Models;

public abstract class Person
{
    public string? Name { get; set; }
    public string? Organisation { get; set; }
    public string? Bio { get; set; }
    public string? ProfileImageUrl { get; set; }
    public SocialMedia? Social { get; set; }
}
