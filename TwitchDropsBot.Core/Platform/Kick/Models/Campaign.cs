using System.Text.Json.Serialization;

namespace TwitchDropsBot.Core.Platform.Kick.Models;

public partial class Campaign
{
    [JsonPropertyName("category")]
    public Category? Category { get; set; }

    [JsonPropertyName("channels")] public List<Channel> Channels { get; set; } = new List<Channel>();
    
    [JsonPropertyName("connect_url")]
    public string ConnectUrl { get; set; } = null!;
    
    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }
    
    [JsonPropertyName("ends_at")]
    public DateTime EndsAt { get; set; }
    
    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;
    
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;
    
    [JsonPropertyName("organization")]
    public Organization organization { get; set; } = null!;
    
    [JsonPropertyName("rewards")]
    public List<Reward> Rewards { get; set; } = null!;
    
    [JsonPropertyName("rule")]
    public Rule rule { get; set; } = null!;
    
    [JsonPropertyName("starts_at")]
    public DateTime StartsAt { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; } = null!; // in_progress, claimed, expired, upcomming

    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; } = null!;
}