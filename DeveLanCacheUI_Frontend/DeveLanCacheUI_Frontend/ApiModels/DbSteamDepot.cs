using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DeveLanCacheUI_Frontend.DbModels
{
    public class DbSteamDepot
    {
        [Key]
        public int Id { get; set; }

        public int? SteamAppId { get; set; }
        public App? SteamApp { get; set; }

        [JsonIgnore]
        public virtual ICollection<DbSteamAppDownloadEvent> DownloadEvents { get; set; }
    }
}
