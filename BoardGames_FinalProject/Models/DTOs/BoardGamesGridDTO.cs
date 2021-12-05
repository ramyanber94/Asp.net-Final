using Newtonsoft.Json;

namespace BoardGames_FinalProject.Models.DTOs
{
    public class BoardGamesGridDTO : GridDTO
    {
        [JsonIgnore]
        public const string DefaultFilter = "all";

        public string Name { get; set; } = DefaultFilter;
        public string Price { get; set; } = DefaultFilter;
    }
}
