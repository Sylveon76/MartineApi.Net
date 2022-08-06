

using Newtonsoft.Json;

namespace MartineApiNet.Models.Images 
{
  /// <summary>
  /// Reddit post
  /// </summary>
  public class Author
  {
      /// <summary>
      /// 
      /// </summary>
      [JsonProperty("name")]
      public string Name { get; set; }

      /// <summary>
      /// 
      /// </summary>
      [JsonProperty("url")]
      public string Url { get; set; }
  }

  /// <summary>
  /// 
  /// </summary>
  public class Data
  {
      /// <summary>
      /// 
      /// </summary>
      [JsonProperty("top_type")]
      public string TopType { get; set; }

      /// <summary>
      /// 
      /// </summary>
      [JsonProperty("image_url")]
      public string ImageUrl { get; set; }

      /// <summary>
      /// 
      /// </summary>
      [JsonProperty("subreddit")]
      public Subreddit Subreddit { get; set; }

      /// <summary>
      /// 
      /// </summary>
      [JsonProperty("author")]
      public Author Author { get; set; }

      /// <summary>
      /// 
      /// </summary>
      [JsonProperty("title")]
      public string Title { get; set; }

      /// <summary>
      /// 
      /// </summary>
      [JsonProperty("nsfw")]
      public bool Nsfw { get; set; }

      /// <summary>
      /// 
      /// </summary>
      [JsonProperty("created_at")]
      public long CreatedAt { get; set; }

      /// <summary>
      /// 
      /// </summary>
      [JsonProperty("upvotes")]
      public int Upvotes { get; set; }

      /// <summary>
      /// 
      /// </summary>
      [JsonProperty("downvotes")]
      public int Downvotes { get; set; }

      /// <summary>
      /// 
      /// </summary>
      [JsonProperty("comments")]
      public int Comments { get; set; }

      /// <summary>
      /// 
      /// </summary>
      [JsonProperty("post_url")]
      public string PostUrl { get; set; }
  }

  /// <summary>
  /// 
  /// </summary>
  public class RedditPost
  {
      /// <summary>
      /// 
      /// </summary>
      [JsonProperty("success")]
      public bool Success { get; set; }

      /// <summary>
      /// 
      /// </summary>
      [JsonProperty("message")]
      public object Message { get; set; }

      /// <summary>
      /// 
      /// </summary>
      [JsonProperty("data")]
      public Data Data { get; set; }
  }

  /// <summary>
  /// 
  /// </summary>
  public class Subreddit
  {
      /// <summary>
      /// 
      /// </summary>
      [JsonProperty("name")]
      public string Name { get; set; }

      /// <summary>
      /// 
      /// </summary>
      [JsonProperty("num_members")]
      public int NumMembers { get; set; }

      /// <summary>
      /// 
      /// </summary>
      [JsonProperty("url")]
      public string Url { get; set; }
  }
}