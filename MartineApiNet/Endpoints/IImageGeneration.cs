using System.Threading.Tasks;
using Refit;
using System.Net.Http;

namespace MartineApiNet.Endpoints 
{
    public interface IImageGenerationApi 
    {
        /// <summary>
        /// Generates a ship image based on given parameters
        /// </summary>
        /// <param name="percent">The percentage to use</param>
        /// <param name="firstUserAvatar">Url of the first user avatar</param>
        /// <param name="secondUserAvatar">Url of the second user avatar</param>
        /// <param name="customSixtyNinePercentEmoji">Whether to use a different emoji for 69%</param>
        /// <returns>Reddit Post</returns>
        [Get("/imagesgen/ship")]
        Task<HttpContent> GenerateShipImage(
            int percent, 
            [AliasAs("first_user")] string firstUserAvatar, 
            [AliasAs("second_user")] string secondUserAvatar, 
            [AliasAs("no_69_percent_emoji")] bool customSixtyNinePercentEmoji = true);

        /// <summary>
        /// Gets the given user's osu! profile card
        /// </summary>
        /// <param name="osuUsername">The username of the user</param>
        [Get("/imagesgen/osuprofile")]
        Task<HttpContent> GetOsuProfileCard([AliasAs("player_username")] string osuUsername);
    }
}