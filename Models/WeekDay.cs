using System;
using System.Collections.Generic;

#nullable disable

namespace APIAPI
{
    public partial class WeekDay
    {
        public WeekDay()
        {
            Schedules = new HashSet<Schedule>();
        }

        public string NameWeekDay { get; set; }

        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
