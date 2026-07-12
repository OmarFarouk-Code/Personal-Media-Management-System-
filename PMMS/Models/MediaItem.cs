using System;
using System.Collections.Generic;
namespace PMMS.Models;

public class MediaItem
{
    public int Id { get; set; }
    public String title { get; set; }
    public MediaType type { get; set; }
    public string Genre { get; set; }
    public DateTime? ReleaseDate { get; set; }
    public WatchStatus  Status { get; set; }
    public int? UserRating { get; set; }
    public int? TotalSeasons { get; set; }
    public int? TotalEpisodes { get; set; }
    public List<WatchLog> WatchLogs { get; set; } = new List<WatchLog> { };
}