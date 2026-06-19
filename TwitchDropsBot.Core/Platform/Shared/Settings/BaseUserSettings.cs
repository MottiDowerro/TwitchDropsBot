namespace TwitchDropsBot.Core.Platform.Shared.Settings;

public class BaseUserSettings
{
    public string Login { get; set; } = null!;
    public string Id { get; set; } = null!;
    public bool Enabled { get; set; }
    public List<string> FavouriteGames { get; set; } = new List<string>();
}