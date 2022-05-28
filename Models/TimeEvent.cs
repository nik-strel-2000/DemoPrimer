using System;
using System.Collections.Generic;

#nullable disable

namespace APIAPI
{
    public partial class TimeEvent
    {
        public TimeEvent()
        {
            Schedules = new HashSet<Schedule>();
        }

        public string TimeEvent1 { get; set; }

        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
