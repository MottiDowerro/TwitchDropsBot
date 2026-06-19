using System.Text.Json.Serialization;

namespace TwitchDropsBot.Core.Platform.Kick.Models;

public class Channel
{
    [JsonPropertyName("banner_picture_url")]
    public string BannerPictureUrl { get; set; } = null!;
    
    [JsonPropertyName("description")]
    public string Description { get; set; } = null!;
    
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("slug")]
    public string slug { get; set; } = null!;
    
    [JsonPropertyName("user")]
    public User user { get; set; } = null!;
    
    [JsonPropertyName("livestream")]
    public Livestream Livestream { get; set; } = null!;
}