using System;
using System.Net.Http;
using System.Net.Http.Headers;
using MartineApiNet.Endpoints;
using Refit;

namespace MartineApiNet 
{
  /// <summary>
  /// The main class for api fields
  /// </summary>
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
        BaseAddress = new Uri(BaseUrl),
        DefaultRequestHeaders = { UserAgent = { new ProductInfoHeaderValue("MartineApi.Net"," v1.0.7") }}
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