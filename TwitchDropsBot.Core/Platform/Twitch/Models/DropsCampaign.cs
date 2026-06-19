using System.Text.Json.Serialization;

namespace TwitchDropsBot.Core.Platform.Twitch.Models;

using System;
using System.Collections.Generic;

public class DropsCampaign
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;

    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("brandName")]
    public string BrandName { get; set; } = null!;

    [JsonPropertyName("detailsURL")]
    public string DetailsURL { get; set; } = null!;

    [JsonPropertyName("startAt")]
    public DateTime StartAt { get; set; }

    [JsonPropertyName("endAt")]
    public DateTime EndAt { get; set; }

    [JsonPropertyName("imageURL")]
    public string ImageURL { get; set; } = null!;

    [JsonPropertyName("hasViewerDismissedHighlight")]
    public bool HasViewerDismissedHighlight { get; set; }

    [JsonPropertyName("isPermanentlyDismissible")]
    public bool IsPermanentlyDismissible { get; set; }

    [JsonPropertyName("game")]
    public Game Game { get; set; } = null!;

    [JsonPropertyName("rewardGroups")]
    public List<DropsRewardGroup> RewardGroups { get; set; } = null!;

}

// Reward Groups
public class DropsRewardGroup
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;

    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("progressCriteria")]
    public DropsProgressCriteria ProgressCriteria { get; set; } = null!;

    [JsonPropertyName("rewards")]
    public List<DropsReward> Rewards { get; set; } = null!;

    [JsonPropertyName("self")]
    public DropsRewardGroupSelfEdge Self { get; set; } = null!;

}

public class DropsProgressCriteria
{
    [JsonPropertyName("requirementType")]
    public string RequirementType { get; set; } = null!;  // SUBS

    [JsonPropertyName("requirements")]
    public DropsUnlockRequirement Requirements { get; set; } = null!;

    [JsonPropertyName("channels")]
    public string Channels { get; set; } = null!;

}

public class DropsUnlockRequirement
{
    [JsonPropertyName("minutesWatched")]
    public int? MinutesWatched { get; set; }

    [JsonPropertyName("subs")]
    public int? Subs { get; set; }

    [JsonPropertyName("turboSubs")]
    public int? TurboSubs { get; set; }

}

public class DropsReward
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;

    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("thumbnailURL")]
    public string ThumbnailURL { get; set; } = null!;

    [JsonPropertyName("distributionType")]
    public DistributionType DistributionType { get; set; }

    [JsonPropertyName("accountLinkURL")]
    public string AccountLinkURL { get; set; } = null!;

    [JsonPropertyName("isAccountConnected")]
    public bool IsAccountConnected { get; set; }

}

public class DropsRewardGroupSelfEdge
{
    [JsonPropertyName("status")] // CLAIMED | IN_PROGRESS
    public string Status { get; set; } = null!;

    [JsonPropertyName("currentMinutesWatched")]
    public int? CurrentMinutesWatched { get; set; }

    [JsonPropertyName("currentSubs")]
    public int? CurrentSubs { get; set; }

}