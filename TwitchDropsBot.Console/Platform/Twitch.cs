using Microsoft.Extensions.Logging;
using TwitchDropsBot.Core;

using TwitchDropsBot.Core.Platform.Shared.Services;
using TwitchDropsBot.Core.Platform.Twitch.Services;
using TwitchDropsBot.Core.Platform.Twitch.Settings;

namespace TwitchDropsBot.Console.Platform;

public class Twitch
{
    public static async Task AuthTwitchDeviceAsync(SettingsManager manager, ILogger logger)
    {
        var jsonResponse = await TwitchAuthService.GetCodeAsync();
        var deviceCode = jsonResponse.RootElement.GetProperty("device_code").GetString();
        var userCode = jsonResponse.RootElement.GetProperty("user_code").GetString();
        var verificationUri = jsonResponse.RootElement.GetProperty("verification_uri").GetString();

        logger.LogInformation($"Please go to {verificationUri} and enter the code: {userCode}");

        if (deviceCode is null)
        {
            logger.LogError("Failed to get device code.");
            Environment.Exit(1);
        }

        jsonResponse = await TwitchAuthService.CodeConfirmationAsync(deviceCode, logger);

        if (jsonResponse == null)
        {
            logger.LogError("Failed to authenticate the user.");
            Environment.Exit(1);
        }

        var secret = jsonResponse.RootElement.GetProperty("access_token").GetString();

        if (secret is null)
        {
            logger.LogError("Failed to get secret.");
            Environment.Exit(1);
        }

        TwitchUserSettings user = await TwitchAuthService.ClientSecretUserAsync(secret);

        var settings = manager.Read();

        var globalGames = settings.FavouriteGames;
        if (globalGames != null && globalGames.Count > 0)
        {
            logger.LogInformation("Available favorite games (Global Config):");
            logger.LogInformation("0. None (Clear favorites)");
            for (int i = 0; i < globalGames.Count; i++)
            {
                logger.LogInformation($"{i + 1}. {globalGames[i]}");
            }
            logger.LogInformation("Enter game numbers separated by space (e.g. '1 3'), '0' to clear, or press Enter to skip:");

            var input = System.Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                user.FavouriteGames = new List<string>();
                var parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                foreach (var part in parts)
                {
                    if (int.TryParse(part, out int index))
                    {
                        if (index == 0)
                        {
                            user.FavouriteGames.Clear();
                            break;
                        }
                        if (index > 0 && index <= globalGames.Count)
                        {
                            var selectedGame = globalGames[index - 1];
                            if (!user.FavouriteGames.Contains(selectedGame))
                            {
                                user.FavouriteGames.Add(selectedGame);
                            }
                        }
                    }
                }
                logger.LogInformation($"Selected games for {user.Login}: {(user.FavouriteGames.Count > 0 ? string.Join(", ", user.FavouriteGames) : "None")}");
            }
            else
            {
                logger.LogInformation($"Skipped. Defaulting to empty list.");
            }
        }

        // Save the user into config.json
        settings.TwitchSettings.TwitchUsers.RemoveAll(x => x.Id == user.Id);
        settings.TwitchSettings.TwitchUsers.Add(user);
        manager.Save(settings);
    }
}