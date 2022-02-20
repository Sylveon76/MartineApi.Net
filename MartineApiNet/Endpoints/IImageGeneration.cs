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
        /// <param name="first_user">Url of the first user avatar</param>
        /// <param name="second_user">Url of the second user avatar</param>
        /// <param name="no_69_percent_emoji">Wether to use a different emoji for 69%</param>
        /// <returns>Reddit Post</returns>
        [Get("/imagesgen/ship")]
        Task<HttpContent> GenerateShipImage(int percent, int first_user, int second_user, bool no_69_percent_emoji = false);

        /// <summary>
        /// Gets the given user's osu! profile card
        /// </summary>
        /// <param name="player_username">The username of the user</param>
        [Get("/imagesgen/osuprofile")]
        Task<HttpContent> GetOsuProfileCard(string player_username);
    }
}