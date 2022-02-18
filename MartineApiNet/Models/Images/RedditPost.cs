using System.Text.Json.Serialization;

namespace MartineApiNet.Models.Images 
{
  /// <summary>
  /// Reddit post
  /// </summary>
  public class Subreddit
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("num_members")]
        public int NumMembers { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class Author
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class Data
    {
        [JsonPropertyName("top_type")]
        public string TopType { get; set; }

        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }

        [JsonPropertyName("subreddit")]
        public Subreddit Subreddit { get; set; }

        [JsonPropertyName("author")]
        public Author Author { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("nsfw")]
        public bool Nsfw { get; set; }

        [JsonPropertyName("created_at")]
        public int CreatedAt { get; set; }

        [JsonPropertyName("upvotes")]
        public int Upvotes { get; set; }

        [JsonPropertyName("downvotes")]
        public int Downvotes { get; set; }

        [JsonPropertyName("comments")]
        public int Comments { get; set; }

        [JsonPropertyName("post_url")]
        public string PostUrl { get; set; }
    }

    public class RedditPost
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("message")]
        public object Message { get; set; }

        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }
}