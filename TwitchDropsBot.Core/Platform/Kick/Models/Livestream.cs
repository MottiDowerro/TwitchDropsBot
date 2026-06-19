using System.Text.Json.Serialization;

namespace TwitchDropsBot.Core.Platform.Kick.Models;

public class Livestream
{
    [JsonPropertyName("categories")]
    public List<Category> Category { get; set; } = null!;
    
    [JsonPropertyName("channel")]
    public Channel Channel { get; set; } = null!;
    
    // fixme
    [JsonPropertyName("id")]
    public dynamic Id { get; set; } = null!;
    
    [JsonPropertyName("is_mature")]
    public bool IsMature { get; set; }
    
    [JsonPropertyName("language")]
    public string Language { get; set; } = null!;
    
    [JsonPropertyName("start_time")]
    public string StartTime { get; set; } = null!;
    
    [JsonPropertyName("tags")]
    public List<string> tags { get; set; } = null!;
    
    [JsonPropertyName("thumbnail")]
    public Thumbnail Thumbnail { get; set; } = null!;
    
    [JsonPropertyName("title")]
    public string Title { get; set; } = null!;
    
    [JsonPropertyName("viewer_count")]
    public int ViewerCount { get; set; }
}

public class Thumbnail
{
    [JsonPropertyName("src")]
    public string Src { get; set; } = null!;
    
    [JsonPropertyName("srcset")]
    public string Srcset { get; set; } = null!;
}