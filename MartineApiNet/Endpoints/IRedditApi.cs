using System.Threading.Tasks;
using MartineApiNet.Models.Images;
using Refit;

namespace MartineApiNet.Endpoints 
{
  public enum TopType
  {
    Year,
    Month,
    Week,
    Day
  }
  /// <summary>
  /// Query the reddit api for memes, subreddits, and wallpapers!
  /// </summary>
  public interface IRedditApi {
    /// <summary>
    /// Gets a random meme
    /// </summary>
    /// <param name="type">Sets the range to look in.</param>
    /// <returns>Reddit Post</returns>
    [Get("/images/memes")]
    Task<RedditPost> GetRandomMeme(TopType type = TopType.Week);
    
    /// <summary>
    /// Gets a random wallpaper from reddit
    /// </summary>
    /// <param name="type">Sets the range to look in.</param>
    /// <returns>Reddit Post</returns>
    [Get("/images/wallpaper")]
    Task<RedditPost> GetRandomWallpaper(TopType type = TopType.Week);

    /// <summary>
    /// Gets a random wallpaper from reddit
    /// </summary>
    /// <param name="subredditName">The subreddit you wanna look for</param>
    /// <param name="type">Sets the range to look in.</param>
    /// <returns>Reddit Post</returns>
    [Get("/images/subreddit")]
    Task<RedditPost> GetRandomFromSubreddit(string subredditName, TopType type = TopType.Week);
    
  }
}
