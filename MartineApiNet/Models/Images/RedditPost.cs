using System.Text.Json.Serialization;

namespace MartineApiNet.Models.Images 
{
  /// <summary>
  /// Reddit post
  /// </summary>
  public class Subreddit
    {
        /// <summary>
        /// The name of the subreddit
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Amount of members subscribed to the subreddit
        /// </summary>
        [JsonPropertyName("num_members")]
        public int NumMembers { get; set; }

        /// <summary>
        /// The url of the subreddit
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    /// <summary>
    /// The author of the post
    /// </summary>
    public class Author
    {
        /// <summary>
        /// The name of the author
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Url to the authors profile
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    /// <summary>
    /// Root class for parsing from the api
    /// </summary>
    public class Data
    {
        /// <summary>
        /// The requested post sorting type
        /// </summary>
        [JsonPropertyName("top_type")]
        public string TopType { get; set; }

        /// <summary>
        /// The url to the posts image, if any. Empty if there is no image.
        /// </summary>
        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; } = "";

        /// <summary>
        /// The subreddit that was requested from.
        /// </summary>
        [JsonPropertyName("subreddit")]
        public Subreddit Subreddit { get; set; }

        /// <summary>
        /// The author this post is from.
        /// </summary>
        [JsonPropertyName("author")]
        public Author Author { get; set; }

        /// <summary>
        /// The title of this post.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Whether this post is NSFW
        /// </summary>
        [JsonPropertyName("nsfw")]
        public bool Nsfw { get; set; }

        /// <summary>
        /// Appears to be a timestamp
        /// </summary>
        [JsonPropertyName("created_at")]
        public long CreatedAt { get; set; }

        /// <summary>
        /// The amount of upvotes this post has.
        /// </summary>
        [JsonPropertyName("upvotes")]
        public int Upvotes { get; set; }

        /// <summary>
        /// The amount of downvotes this post has.
        /// </summary>
        [JsonPropertyName("downvotes")]
        public int Downvotes { get; set; }

        /// <summary>
        /// The amount of comments this post has.
        /// </summary>
        [JsonPropertyName("comments")]
        public int Comments { get; set; }

        /// <summary>
        /// The url to the post.
        /// </summary>
        [JsonPropertyName("post_url")]
        public string PostUrl { get; set; }
    }

    /// <summary>
    /// The requested post.
    /// </summary>
    public class RedditPost
    {
        /// <summary>
        /// Whether getting a post was successful
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        /// <summary>
        /// The message returned by the server if getting a post was unsuccessful 
        /// </summary>
        [JsonPropertyName("message")]
        public object Message { get; set; }

        /// <summary>
        /// The post's data.
        /// </summary>
        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }
}