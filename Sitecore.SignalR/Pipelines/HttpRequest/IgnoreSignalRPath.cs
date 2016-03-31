using System;

namespace Sitecore.SignalR.Pipelines.HttpRequest
{
  using Sitecore.Diagnostics;
  using Sitecore.Pipelines.HttpRequest;
  using Sitecore.SignalR.Configuration;

  public class IgnoreSignalRPath : HttpRequestProcessor
  {
    #region Public methods

    /// <summary>
    /// Runs the processor.
    /// </summary>
    /// <param name="args">The arguments.</param>
    public override void Process([NotNull] HttpRequestArgs args)
    {
      Assert.ArgumentNotNull(args, nameof(args));
      if (args.Url.FilePath.StartsWith(Settings.SignalR.Path, StringComparison.OrdinalIgnoreCase))
      {
        args.AbortPipeline();
      }
    }

    #endregion
  }
}
