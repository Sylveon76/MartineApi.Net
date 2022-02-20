using System.Threading.Tasks;
using MartineApiNet.Enums;
using MartineApiNet.Models.Images;
using Refit;

namespace MartineApiNet.Endpoints 
{
  /// <summary>
  /// Query the reddit api for memes, subreddits, and wallpapers!
  /// </summary>
  public interface IRedditApi 
  {
    /// <summary>
    /// Gets a random meme
    /// </summary>
    /// <param name="topType">Sets the range to look in.</param>
    /// <returns>Reddit Post</returns>
    [Get("/images/memes")]
    Task<RedditPost> GetRandomMeme([AliasAs("top_type")] Toptype topType = Toptype.week);
    
    /// <summary>
    /// Gets a random wallpaper from reddit
    /// </summary>
    /// <param name="topType">Sets the range to look in.</param>
    /// <returns>Reddit Post</returns>
    [Get("/images/wallpaper")]
    Task<RedditPost> GetRandomWallpaper([AliasAs("top_type")] Toptype topType = Toptype.week);

    /// <summary>
    /// Gets a random wallpaper from reddit
    /// </summary>
    /// <param name="name">The subreddit you wanna look for</param>
    /// <param name="topType">Sets the range to look in.</param>
    /// <returns>Reddit Post</returns>
    [Get("/images/subreddit")]
    Task<RedditPost> GetRandomFromSubreddit(string name, [AliasAs("top_type")] Toptype topType = Toptype.week);
    
  }
}
