namespace TwitchDropsBot.Core.Platform.Shared.Exceptions;

[Serializable]
public class StreamOffline : System.Exception
{
    private const string DefaultMessage = "The stream goes offline.";


    public StreamOffline() : base(DefaultMessage) { }
    public StreamOffline(string message) : base(message) { }
    public StreamOffline(string message, System.Exception inner) : base(message, inner) { }

}


