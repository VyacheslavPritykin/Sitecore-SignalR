# Sitecore SignalR
SignalR support for Sitecore.

## How to install?

1. To use Sitecore SignalR you should install [Sitecore OWIN](https://github.com/VyacheslavPritykin/Sitecore-Owin) module first. Here is the [how to install](https://github.com/VyacheslavPritykin/Sitecore-Owin/blob/master/README.md#how-to-install) guide.
2. Add the following assembly bindings into the _Web.config_ `runtime/assemblyBinding`:

  ```xml
  <dependentAssembly>
    <assemblyIdentity name="Microsoft.Owin" publicKeyToken="31bf3856ad364e35" culture="neutral" />
    <bindingRedirect oldVersion="0.0.0.0-3.0.1.0" newVersion="3.0.1.0" />
  </dependentAssembly>
  <dependentAssembly>
    <assemblyIdentity name="Microsoft.Owin.Security" publicKeyToken="31bf3856ad364e35" culture="neutral" />
    <bindingRedirect oldVersion="0.0.0.0-3.0.1.0" newVersion="3.0.1.0" />
  </dependentAssembly>
  ``` 
3. Follow the link [Sitecore SignalR _(link will be updated later)_](https://marketplace.sitecore.net/) to download the package from Sitecore Marketplace and install it via Sitecore Installation Wizard.

## How to use?
After installing, SignalR can handle requests made to _your_site_domain/signalr*_. URL prefix could be changed in the _Sitecore.SignalR.config_.

A set of assemblies and JavaScript files that necessary to run SignalR application will be also available.
