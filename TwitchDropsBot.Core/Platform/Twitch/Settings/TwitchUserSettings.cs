using TwitchDropsBot.Core.Platform.Shared.Settings;

namespace TwitchDropsBot.Core.Platform.Twitch.Settings;

public class TwitchUserSettings : BaseUserSettings
{
    public string ClientSecret { get; set; } = null!;
    public string UniqueId { get; set; } = null!;
}