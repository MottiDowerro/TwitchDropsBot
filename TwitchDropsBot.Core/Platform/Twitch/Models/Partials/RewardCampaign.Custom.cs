using System.Text.Json.Serialization;
using Discord;
using TwitchDropsBot.Core.Platform.Twitch.Bot;
using TwitchDropsBot.Core.Platform.Twitch.Models.Abstractions;
using TwitchDropsBot.Core.Platform.Twitch.Repository;

namespace TwitchDropsBot.Core.Platform.Twitch.Models;

public partial class RewardCampaign : AbstractCampaign
{
    public DistributionType DistributionType { get; set; }
    
    public override Task<bool> IsCompleted(Inventory inventory, TwitchGqlRepository _repository)
    {
        if (inventory.CompletedRewardCampaigns is null)
        {
            return Task.FromResult(false);
        }

        List<CompletedRewardCampaigns> completedRewardCampaigns = inventory.CompletedRewardCampaigns;

        var anyCompletedRewardCampaigns = completedRewardCampaigns.Any(x => x.Id == Id);

        return Task.FromResult(anyCompletedRewardCampaigns);
    }
}