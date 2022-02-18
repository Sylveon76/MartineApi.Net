using System.Threading.Tasks;
using Refit;
using System.Net.Http;

namespace MartineApiNet.Endpoints 
{
    public interface IImageGenerationApi {
        /// <summary>
        /// Generates a ship image based on given parameters
        /// </summary>
        /// <param name="percent">The percentage to use</param>
        /// <param name="firstAvatarUrl">Url of the first user</param>
        /// <param name="secondAvatarUrl">Url of the second user</param>
        /// <param name="useSixtyNinePercentEmoji">Wether to use a different emoji for 69%</param>
        /// <returns>Reddit Post</returns>
        [Get("/imagesgen/ship")]
        Task<HttpContent> GenerateShipImage(int percent, int firstAvatarUrl, int secondAvatarUrl, bool useSixtyNinePercentEmoji = true);

        /// <summary>
        /// Gets the given user's osu! profile card
        /// </summary>
        /// <param name="username">The username of the user</param>
        [Get("/imagesgen/ship")]
        Task<HttpContent> GetOsuProfileCard(string username);
    }
}