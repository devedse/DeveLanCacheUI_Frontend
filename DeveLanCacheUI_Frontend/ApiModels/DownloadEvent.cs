namespace DeveLanCacheUI_Frontend.ApiModels
{
    public class DownloadEvent
    {
        public int Id { get; set; }

        //steam/epicgames/wsus/epicgames
        public string CacheIdentifier { get; set; }

        public uint? DownloadIdentifier { get; set; }
        public string? DownloadIdentifierString { get; set; }

        public required string ClientIp { get; set; }

        public required DateTime CreatedAt { get; set; }
        public required DateTime LastUpdatedAt { get; set; }

        public long CacheHitBytes { get; set; }
        public long CacheMissBytes { get; set; }

        //public ulong TotalBytes { get; set; }


        public DownloadInfo? DownloadInfo { get; set; }
    }
}
