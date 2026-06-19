namespace TwitchDropsBot.Core.Platform.Shared.Exceptions;

[Serializable]
public class CurrentDropSessionChanged : System.Exception
{
    private const string DefaultMessage = "RequiredMinutesWatched is equal to zero, restarting the loop.";


    public CurrentDropSessionChanged() : base(DefaultMessage) { }
    public CurrentDropSessionChanged(string message) : base(message) { }
    public CurrentDropSessionChanged(string message, System.Exception inner) : base(message, inner) { }

}


