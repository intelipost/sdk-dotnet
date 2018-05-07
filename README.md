# Intelipost .Net Client Library

Intelipost is a simple, fast and secure shipping and logistics gateway API. You can sign up for an account at http://www.intelipost.com.br

Installation
------------
Install using NuGet

https://www.nuget.org/packages/api-intelipost/

To install InteliPost API, run the following command in the [Package Manager Console](http://docs.nuget.org/docs/start-here/using-the-package-manager-console)

```PM> Install-Package InteliPost.API```

Usage
------------
Add your Api-Key and log file path:
```csharp
new Configure().Initialize({api_key}, true, {log_path});
```


Documentation
--------------------
Up-to-date documentation at: http://docs.intelipost.com.br


Dependencies
--------------------

- .NETFramework ≥ 4.0
- Newtonsoft.Json (≥ 7.0.1)

Last Release
--------------------
### Release 2.1.0:
- New Change Delivery Method;

> See [all release notes](https://github.com/intelipost/sdk-dotnet/releases)
