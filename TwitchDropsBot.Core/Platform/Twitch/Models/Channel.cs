using System.Text.Json.Serialization;

namespace TwitchDropsBot.Core.Platform.Twitch.Models;

public class Channel
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("viewerDropCampaigns")]
    public DropCampaign? ViewerDropCampaigns { get; set; }

    [JsonPropertyName("self")]
    public ChannelSelfEdge Self { get; set; } = null!;
}

public class ChannelSelfEdge
{
    [JsonPropertyName("availableEmoteSetsPaginated")]
    public EmoteSetsConnection AvailableEmoteSetsPaginated { get; set; } = null!;
    
    [JsonPropertyName("pageInfo")]
    public PageInfo PageInfo { get; set; } = null!;
}

public class EmoteSetsConnection
{
    [JsonPropertyName("edges")]
    public ICollection<EmoteSetsEdge> Edges { get; set; } = new List<EmoteSetsEdge>();
}

public class EmoteSetsEdge
{
    [JsonPropertyName("cursor")]
    public string Cursor { get; set; } = null!;
    
    [JsonPropertyName("node")]
    public EmoteSet Node { get; set; } = null!;
}

public class EmoteSet
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;
    
    [JsonPropertyName("emotes")]
    public ICollection<Emote> emotes { get; set; } = null!;
}

public class Emote
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;
    
    [JsonPropertyName("setID")]
    public string SetId { get; set; } = null!;
    
    [JsonPropertyName("token")]
    public string Token { get; set; } = null!;
    
    // [JsonPropertyName("modifiers")]
    // public string Modifiers { get; set; }
    
    [JsonPropertyName("type")]
    public EmoteType Type { get; set; }
    
    [JsonPropertyName("assertType")]
    public string AssertType { get; set; } = null!;
}

public enum EmoteType
{
    GLOBALS,
    TWO_FACTOR,
    LIMITED_TIME,
    SUBSCRIPTIONS,
    FOLLOWER,
    MEGA_COMMERCE,
    BITREWARDS,
    SMILIES,
    PRIME,
    TURBO,
}