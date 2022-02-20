using System.Threading.Tasks;
using MartineApiNet.Models.Images;
using Refit;

namespace MartineApiNet.Endpoints 
{
  /// <summary>
  /// The randomness span
  /// </summary>
  public enum Toptype
  {
    /// <summary>
    /// Look in the past year for content
    /// </summary>
    Year,
    /// <summary>
    /// Look in the past month for content
    /// </summary>
    Month,
    /// <summary>
    /// Look in the past week for content
    /// </summary>
    Week,
    /// <summary>
    /// Look in the past day for content
    /// </summary>
    Day
  }
  /// <summary>
  /// Query the reddit api for memes, subreddits, and wallpapers!
  /// </summary>
  public interface IRedditApi {
    /// <summary>
    /// Gets a random meme
    /// </summary>
    /// <param name="top_type">Sets the range to look in.</param>
    /// <returns>Reddit Post</returns>
    [Get("/images/memes")]
    Task<RedditPost> GetRandomMeme(Toptype top_type = Toptype.Week);
    
    /// <summary>
    /// Gets a random wallpaper from reddit
    /// </summary>
    /// <param name="top_type">Sets the range to look in.</param>
    /// <returns>Reddit Post</returns>
    [Get("/images/wallpaper")]
    Task<RedditPost> GetRandomWallpaper(Toptype top_type = Toptype.Week);

    /// <summary>
    /// Gets a random wallpaper from reddit
    /// </summary>
    /// <param name="name">The subreddit you wanna look for</param>
    /// <param name="top_type">Sets the range to look in.</param>
    /// <returns>Reddit Post</returns>
    [Get("/images/subreddit")]
    Task<RedditPost> GetRandomFromSubreddit(string name, Toptype top_type = Toptype.Week);
    
  }
}
