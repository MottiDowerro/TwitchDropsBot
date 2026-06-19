using System.Text.Json.Serialization;
using TwitchDropsBot.Core.Platform.Twitch.Models;

namespace TwitchDropsBot.Core.Platform.Twitch.Models;

public partial class User
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("profileURL")]
    public string? ProfileURL { get; set; }

    [JsonPropertyName("login")]
    public string? Login { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("roles")]
    public UserRoles? Roles { get; set; }

    [JsonPropertyName("profileImageURL")]
    public string? ProfileImageURL { get; set; }

    [JsonPropertyName("primaryColorHex")]
    public string? PrimaryColorHex { get; set; }

    [JsonPropertyName("broadcastSettings")]
    public BroadcastSettings? BroadcastSettings { get; set; }

    [JsonPropertyName("stream")]
    public Stream? Stream { get; set; }

    [JsonPropertyName("dropCurrentSession")]
    public DropCurrentSession? DropCurrentSession { get; set; }

    [JsonPropertyName("inventory")]
    public Inventory? Inventory { get; set; }

    [JsonPropertyName("dropCampaign")]
    public DropCampaign? DropCampaign { get; set; }

    [JsonPropertyName("dropCampaigns")]
    public List<DropCampaign>? DropCampaigns { get; set; } = new List<DropCampaign>();

    [JsonPropertyName("notifications")]
    public Notifications? Notifications { get; set; }
    
    [JsonPropertyName("availableBadges")]
    public ICollection<Badge> AvailableBadges { get; set; } = new List<Badge>();
    
}

public class Badge
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;
    
    [JsonPropertyName("setId")]
    public string SetId { get; set; } = null!;
    
    [JsonPropertyName("version")]
    public string Version { get; set; } = null!;
    
    [JsonPropertyName("title")]
    public string Title { get; set; } = null!;
    
    [JsonPropertyName("image1x")]
    public string Image1x { get; set; } = null!;
    
    [JsonPropertyName("image2x")]
    public string Image2x { get; set; } = null!;
    
    [JsonPropertyName("image4x")]
    public string Image4x { get; set; } = null!;
}

public class Notifications
{
    [JsonPropertyName("pageInfo")]
    public PageInfo PageInfo { get; set; } = null!;
    
    [JsonPropertyName("edges")]
    public List<OnsiteNotificationEdge> Edges { get; set; } = new List<OnsiteNotificationEdge>();
    
}

public class PageInfo
{
    [JsonPropertyName("hasNextPage")]
    public bool HasNextPage { get; set; }
}

public class OnsiteNotificationEdge
{
    [JsonPropertyName("node")]
    public OnsiteNotification Node { get; set; } = null!;
}

public class OnsiteNotification
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;
    
    [JsonPropertyName("type")]
    public string Type { get; set; } = null!;
    
    [JsonPropertyName("body")]
    public string Body { get; set; } = null!;
    
    [JsonPropertyName("renderStyle")]
    public string RenderStyle { get; set; } = null!;
    
    [JsonPropertyName("createdAt")]
    public DateTime? CreatedAt { get; set; }
    
    [JsonPropertyName("updatedAt")]
    public DateTime? UpdatedAt { get; set; }
    
    [JsonPropertyName("isRead")]
    public bool IsRead { get; set; }
    
    [JsonPropertyName("ThumbnailURL")]
    public string ThumbnailUrl { get; set; } = null!;
    
    [JsonPropertyName("actions")]
    public List<OnsiteNotificationAction> Actions { get; set; } = new List<OnsiteNotificationAction>();
    
    [JsonPropertyName("displayType")]
    public string DisplayType { get; set; } = null!;
    
    [JsonPropertyName("aggregationType")]
    public string AggregationType { get; set; } = null!;
    
    [JsonPropertyName("collapseKey")]
    public string CollapseKey { get; set; } = null!;
    
    [JsonPropertyName("destinationType")]
    public string DestinationType { get; set; } = null!;
    
    [JsonPropertyName("IsMobileOnly")]
    public bool IsMobileOnly { get; set; }
}

public class OnsiteNotificationAction
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;
    
    [JsonPropertyName("label")]
    public string Label { get; set; } = null!;
    
    [JsonPropertyName("modalID")]
    public string ModalID { get; set; } = null!;
    
    [JsonPropertyName("body")]
    public string Body { get; set; } = null!;
    
    [JsonPropertyName("type")]
    public string Type { get; set; } = null!;
    
    [JsonPropertyName("url")]
    public string Url { get; set; } = null!;
}

