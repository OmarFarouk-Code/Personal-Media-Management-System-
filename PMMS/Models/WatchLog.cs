using System;
using System.Collections.Generic;

namespace PMMS.Models;

public class WatchLog
{
    public int Id { get; set; }
    // Foreign key
    public int MediaItemId { get; set; }
    public int? SeasonNumber { get; set; }
    public int? EpisodeNumber { get; set; }
    public DateTime WatchOn { get; set; }
    public string Notes { get; set; }
    public MediaItem MediaItem { get; set; }
}
