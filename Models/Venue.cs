using System;
using System.Collections.Generic;

#nullable disable

namespace APIAPI
{
    public partial class Venue
    {
        public Venue()
        {
            Schedules = new HashSet<Schedule>();
        }

        public long IdVenue { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
