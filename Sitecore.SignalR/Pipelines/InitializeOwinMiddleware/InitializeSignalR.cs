using Owin;

namespace Sitecore.SignalR.Pipelines.InitializeOwinMiddleware
{
  using Microsoft.AspNet.SignalR;

  using Sitecore.Diagnostics;
  using Sitecore.Owin.Pipelines.Initialize;
  using Sitecore.SignalR.Configuration;

  public class InitializeSignalR : InitializeProcessor
  {
    public override void Process([NotNull] InitializeArgs args)
    {
      Assert.ArgumentNotNull(args, nameof(args));
      args.App.MapSignalR(Settings.SignalR.Path, new HubConfiguration());
    }
  }
}
