using System;

namespace DesktopStickyNote
{
    public class Event
    {
        public string Id { get; set; }
        public string Category { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Details { get; set; }
    }
}
