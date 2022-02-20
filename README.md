# MartineApi Wrapper

[![nuget version][0]][1]
[![downloads][2]][1]

> https://api.martinebot.com/v1/docs

## Overview

[MartineAPI](https://api.martinebot.com/v1/docs) is a an API made by the owner of [Martine Bot](https://martinebot.com) 

### If you find any errors/issues or want any features added, [create an issue](https://github.com/Sylveon76/MartineApi.Net/issues/new/)

## Getting started

### Installing the package

Add the NuGet package `MartineApiNet` to your project:

```ps
dotnet add package MartineApiNet
```

### Simple usage


```cs
using System;
using System.Threading.Tasks;
using MartineApiNet;

public class ExampleClass
{
  private readonly MartineApi _martineApi;

  public ExampleClass() 
    => _martineApi = new MartineApi();

  public async Task GetRandomMeme() 
  {
    var image = await _martineApi.RedditApi.GetRandomMeme();

    Console.WriteLine(image.Data.PostUrl);
  }
}
```

### Example using custom HttpClient

You can provide your own HttpClient instance, but you have to set the BaseAddress manually

```cs
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using MartineApiNet;

public ExampleClass() 
{
  var httpClient = new HttpClient 
  {
    BaseAddress = new Uri("https://api.martinebot.com/v1")
  };

  _martineApi = new MartineApi(httpClient);
}
```

### Example using dependency injection

Create a ServiceCollection, then add an instance of the MartineApi class to it


```cs
using System;
using System.Threading.Tasks;
using MartineApiNet;
using Microsoft.Extensions.DependencyInjection;

public class Startup 
{
  private MartineApi _martineApi;

  private IServiceProvider _serviceProvider;

  public void Init() 
  {
    var services = new ServiceCollection();

    _martineApi = new MartineApi();

    ConfigureServices(services);
    _serviceProvider = services.BuildServiceProvider();
  }

  public async Task RunAsync() 
  {
    var exampleClass = _serviceProvider.GetService<ExampleClass>();

    var image = await exampleClass.GetRandomMeme();

    Console.WriteLine(image.Data.PostUrl);
  }

  private void ConfigureServices(IServiceCollection services) 
  {
    services.AddSingleton(_martineApi);
    services.AddSingleton<ExampleClass>();
  }
}
```

Using this in a class:

```cs
using System.Threading.Tasks;
using MartineApiNet;
using MartineApiNet.Models.Images;

public class ExampleClass 
{
  private readonly MartineApi _martineApi;

  public ExampleClass(MartineApi martineApi) 
    => _martineApi = martineApi;

  public async Task<RedditPost> GetRandomMeme()
    => await _martineApi.GetRandomMeme();
}
```

[0]: https://img.shields.io/nuget/v/MartineApiNet?style=flat-square

[1]: https://www.nuget.org/packages/MartineApiNet

[2]: https://img.shields.io/nuget/dt/MartineApiNet?style=flat-square
