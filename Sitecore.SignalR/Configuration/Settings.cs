namespace Sitecore.SignalR.Configuration
{
  public static class Settings
  {
    public static class SignalR
    {
      public static string Path => Sitecore.Configuration.Settings.GetSetting("SignalR.Path", "/signalr");
    }
  }
}

