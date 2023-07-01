using System.ComponentModel.DataAnnotations;

namespace DeveLanCacheUI_Frontend.DbModels
{
    public class DbSteamApp
    {
        [Key]
        public int Id { get; set; }
        public string AppName { get; set; }
    }
}
