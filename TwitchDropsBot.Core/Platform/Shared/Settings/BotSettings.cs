using TwitchDropsBot.Core.Platform.Kick.Settings;
using TwitchDropsBot.Core.Platform.Twitch.Settings;

namespace TwitchDropsBot.Core.Platform.Shared.Settings;

public class BotSettings
{
    public TwitchSettings TwitchSettings { get; set; } = new TwitchSettings();
    public KickSettings KickSettings { get; set; } = new KickSettings();
    public List<string> FavouriteGames { get; set; } = new List<string>();
    public bool LaunchOnStartup { get; set; } = false;
    public int LogLevel { get; set; } = 0;
    public string? WebhookURL { get; set; } = string.Empty;
    public double WaitingSeconds { get; set; } = TimeSpan.FromMinutes(5).TotalSeconds;
    public double? MinWaitingSeconds { get; set; } = 150;
    public double? MaxWaitingSeconds { get; set; } = 450;
    public double? MinWatchCheckIntervalSeconds { get; set; } = 25;
    public double? MaxWatchCheckIntervalSeconds { get; set; } = 75;
    public int AttemptToWatch { get; set; } = 5;

    public double GetWaitingSeconds()
    {
        if (MinWaitingSeconds.HasValue && MaxWaitingSeconds.HasValue)
        {
            var min = Math.Min(MinWaitingSeconds.Value, MaxWaitingSeconds.Value);
            var max = Math.Max(MinWaitingSeconds.Value, MaxWaitingSeconds.Value);
            return Random.Shared.NextDouble() * (max - min) + min;
        }
        return WaitingSeconds;
    }

    public double GetWatchCheckIntervalSeconds(double defaultSeconds)
    {
        if (MinWatchCheckIntervalSeconds.HasValue && MaxWatchCheckIntervalSeconds.HasValue)
        {
            var min = Math.Min(MinWatchCheckIntervalSeconds.Value, MaxWatchCheckIntervalSeconds.Value);
            var max = Math.Max(MinWatchCheckIntervalSeconds.Value, MaxWatchCheckIntervalSeconds.Value);
            return Random.Shared.NextDouble() * (max - min) + min;
        }
        return defaultSeconds;
    }
    public bool WatchBrowserHeadless { get; set; } = true;
    public bool MinimizeInTray { get; set; } = false;
}