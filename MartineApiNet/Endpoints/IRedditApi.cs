using System.Threading.Tasks;
using MartineApiNet.Models.Images;
using Refit;

namespace MartineApiNet.Endpoints 
{
  public class TopType 
  {

    /// <summary>
    /// Get all posts
    /// </summary>
    public const string All = "all";
    /// <summary>
    /// Get posts from the past year
    /// </summary>
    public const string Year = "year";
    /// <summary>
    /// Get posts from the past month
    /// </summary>
    public const string Month = "month";
    /// <summary>
    /// Get posts from the past week
    /// </summary>
    public const string Week = "week";
    /// <summary>
    /// get posts from the last 24 hours
    /// </summary>
    public const string Day = "Day";
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
    Task<RedditPost> GetRandomMeme(TopType type = null);
    
    /// <summary>
    /// Gets a random wallpaper from reddit
    /// </summary>
    /// <param name="type">Sets the range to look in.</param>
    /// <returns>Reddit Post</returns>
    [Get("/images/wallpaper")]
    Task<RedditPost> GetRandomWallpaper(TopType type = null);

    /// <summary>
    /// Gets a random wallpaper from reddit
    /// </summary>
    /// <param name="subredditName">The subreddit you wanna look for</param>
    /// <param name="type">Sets the range to look in.</param>
    /// <returns>Reddit Post</returns>
    [Get("/images/subreddit")]
    Task<RedditPost> GetRandomFromSubreddit(string subredditName, TopType type = null);
    
  }
}
