using System;
using System.Collections.Generic;

#nullable disable

namespace APIAPI
{
    public partial class Schedule
    {
        public long IdSchedule { get; set; }
        public long VenueId { get; set; }
        public string WeekDayName { get; set; }
        public long EmployeeId { get; set; }
        public string EventTime { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual TimeEvent EventTimeNavigation { get; set; }
        public virtual Venue Venue { get; set; }
        public virtual WeekDay WeekDayNameNavigation { get; set; }
    }
}
