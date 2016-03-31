using Owin;

namespace Sitecore.SignalR.Pipelines.InitializeOwinMiddleware
{
  using Microsoft.AspNet.SignalR;

  using Sitecore.Diagnostics;
  using Sitecore.Owin.Pipelines.InitializeOwinMiddleware;
  using Sitecore.SignalR.Configuration;

  public class InitializeSignalR
  {
    public void Process([NotNull] InitializeOwinMiddlewareArgs args)
    {
      Assert.ArgumentNotNull(args, nameof(args));
      args.App.MapSignalR(Settings.SignalR.Path, new HubConfiguration());
    }
  }
}
