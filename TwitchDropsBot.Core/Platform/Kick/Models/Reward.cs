using System.Text.Json.Serialization;

namespace TwitchDropsBot.Core.Platform.Kick.Models;

public partial class Reward : IEquatable<Reward>
{
    [JsonPropertyName("category_id")]
    public int CategoryId { get; set; }
    
    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;
    
    [JsonPropertyName("image_url")]
    public string ImageUrl { get; set; } = null!;
    
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;
    
    [JsonPropertyName("organization_id")]
    public string organizationId { get; set; } = null!;
    
    [JsonPropertyName("required_units")]
    public int RequiredUnits { get; set; }
    
    [JsonPropertyName("claimed")]
    public bool Claimed { get; set; }
    
    [JsonPropertyName("progress")]
    public double Progress { get; set; }
    
}