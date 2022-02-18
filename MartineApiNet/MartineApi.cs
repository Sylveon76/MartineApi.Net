using System;
using System.Net.Http;
using MartineApiNet.Endpoints;
using Refit;

namespace MartineApiNet 
{
  public class MartineApi 
  {
    private const string BaseUrl = "https://api.martinebot.com/v1";
    /// <summary>
    /// Get memes, wallpapers and query random subreddits.
    /// </summary>
    public IRedditApi RedditApi { get; private set; }
    /// <summary>
    /// Generate ship images and osu profile cards.
    /// </summary>
    public IImageGenerationApi ImageGenerationApi { get; private set; }

    /// <summary>
    /// Constructor with token only
    /// </summary>
    public MartineApi() 
    {
      var httpClient = new HttpClient {
        BaseAddress = new Uri(BaseUrl)
      };
      Initialize(httpClient);
    }

    /// <summary>
    /// Constructor with custom HttpClient, must set BaseAddress and Authorization header manually
    /// </summary>
    /// <param name="httpClient">HttpClient instance</param>
    public MartineApi(HttpClient httpClient) 
        => Initialize(httpClient);

        private void Initialize(HttpClient httpClient)
        {
            RedditApi = RestService.For<IRedditApi>(httpClient);
            ImageGenerationApi = RestService.For<IImageGenerationApi>(httpClient);
        }
  }

}